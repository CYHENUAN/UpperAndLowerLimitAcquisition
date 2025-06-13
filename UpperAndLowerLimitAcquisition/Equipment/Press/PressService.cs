using Acquisition.Common;
using Acquisition.IService;
using MediatR;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UpperAndLowerLimitAcquisition.Helper;
using UpperAndLowerLimitAcquisition.Log;
using UpperAndLowerLimitAcquisition.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UpperAndLowerLimitAcquisition.Equipment.Press
{
    public class PressService
    {      
        private readonly LogService _logService;
        private readonly IUpdateRecipeService _recipeService;
        private readonly IMediator _mediator;
        public BindingList<PressDetailDto> pressDetailDtos = new BindingList<PressDetailDto>();
      
        public PressService(LogService logService, IUpdateRecipeService recipeService, IMediator mediator)
        {
            _logService = logService;
            _recipeService = recipeService;
            _mediator = mediator;
        }

        //单设备压机采集
        public async Task<bool> TryReadFileAsync(DirectoryInfo dirinfo, CancellationToken cancellationToken)
        {          
            try
            {
                var _dirpath = dirinfo.FullName;
                if (!Directory.Exists($"{_dirpath}/bak"))
                    Directory.CreateDirectory($"{_dirpath}/bak");

                if (!Directory.Exists($"{_dirpath}/error"))
                    Directory.CreateDirectory($"{_dirpath}/error");

                var maindirname = dirinfo.Name.Replace(" ", "").Trim();

                var stationNumber = _StationNuberMapp(maindirname);
                //查找对应工位是否设置检测项名称
                var measure = GlobalData.Params?.PressMeasurementData.FirstOrDefault(x => x.StationName == stationNumber);
                //如果不为空则已设置的名称为准
                var mesureStrs = new List<string?>();
                if (measure != null)
                {
                    mesureStrs = new[]
                    {
                        measure.MeasurementOne,
                        measure.MeasurementTwo,
                        measure.MeasurementThree,
                        measure.MeasurementFour,
                        measure.MeasurementFive
                    }
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .ToList();
                }
                //压机日志输出
                _logService.PressLog(0, $"{stationNumber}压力采集准备开始，采集设备：{maindirname}");
                          
                //找到最新的采集目录
                var dirson = dirinfo.GetDirectories().Where(w => w.Name.IsDateTime()).OrderBy(w => w.LastWriteTime).LastOrDefault();

                if (dirson == null)
                {                 
                    _logService.PressLog(2, $"压力采集{maindirname} -> 未找到有效的子目录");

                    var pressListData = CreatePressDetailDto(stationNumber, maindirname, _dirpath, AcquistionState.Failed);
                    //新增失败数据到列表
                    InsertPressDetailDto(pressListData);
                    await _mediator.Publish(new DataListViewNotification() { PanelId = "PressDataGridViewTable", PressDetailDtos = pressDetailDtos }, cancellationToken);
                    return false;
                }
                //如果没有采集文件，则跳过
                if (dirson.GetFiles().Length == 0)
                {
                    var pressListData = CreatePressDetailDto(stationNumber, maindirname, _dirpath, AcquistionState.Failed);
                    InsertPressDetailDto(pressListData);
                    await _mediator.Publish(new DataListViewNotification() { PanelId = "PressDataGridViewTable", PressDetailDtos = pressDetailDtos }, cancellationToken);
                    _logService.PressLog(2, $"压力采集{maindirname} -> 目录{dirson.Name}下没有文件");
                    return false;
                }
                //获取每组压机最新的文件
                //以前缀OK-A125-001分组找到每组最新的文件
                //提取编号部分,Regex.Escape(maindirname) -> 防止动态变量含有特殊字符
                string pattern = @$"OK-{Regex.Escape(maindirname)}-(\d{{3}})";

                var fileGroup = dirson.GetFiles("*.csv")
                   .Where(f => Regex.IsMatch(f.Name, pattern))
                   .GroupBy(f => Regex.Match(f.Name, pattern).Value)
                   .Select(g => g.OrderByDescending(p => p.LastWriteTime).First())
                   .OrderBy(f => int.Parse(Regex.Match(f.Name, pattern).Groups[1].Value))
                   .ToList();

                var keepSet = fileGroup.Select(f => f.FullName).ToHashSet();
                //删除不符合条件的文件
                foreach (var file in dirson.GetFiles("*.csv"))
                {
                    if (!keepSet.Contains(file.FullName))
                    {
                        file.Delete();
                    }
                }

                //创建检测项列表
                List<MeasurementData> measurementDatas = new List<MeasurementData>();
                foreach (var _file in fileGroup)
                {
                    _logService.PressLog(0, $"压力采集:{maindirname} -> 读取到{_file?.FullName}");
                    try
                    {
                        var _v_uslfocre = 0M;//上限
                        var _v_lslfocre = 0M;//下限                  
                        var _v_uslpostion = 0M;//位移上限
                        var _v_lslpostion = 0M;//位移下限

                        using (var _fileopen = _file != null ? new FileStream(_file.FullName, FileMode.Open, FileAccess.Read, FileShare.None) : throw new InvalidOperationException("File is null"))
                        {
                            var f_index = 0;
                            var f_str = "";
                            var strream = new StreamReader(_fileopen, Encoding.GetEncoding("GB2312"));
                            while (f_str != null)
                            {
                                f_str = strream.ReadLine();
                                f_index++;
                                if (f_str == null)
                                    break;

                                if (f_index >= 113 && f_index <= 119)
                                {
                                    _v_uslfocre = 0M;//上限
                                    _v_lslfocre = 0M;//下限
                                    _v_uslpostion = 0M;//位移上限
                                    _v_lslpostion = 0M;//位移下限
                                    var _Eoindex = f_index - 113;

                                    if (!string.IsNullOrWhiteSpace(f_str))
                                    {
                                        //获取判定结果区域数据
                                        //压力lsl
                                        var aa = _getRegexString(@"XMin-Y\.MinSet:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1];
                                        var reg_miny_val = decimal.Parse(_getRegexString(@"XMin-Y\.MinSet:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]);
                                        if ((reg_miny_val < _v_lslfocre) || (reg_miny_val != 0 && _v_lslfocre == 0))
                                            _v_lslfocre = Math.Round(reg_miny_val, 4);

                                        //压力usl
                                        var reg_maxy_val = decimal.Parse(_getRegexString(@"XMax-Y\.MaxSet:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]);
                                        if ((reg_maxy_val > _v_uslfocre) || (reg_maxy_val != 0 && _v_uslfocre == 0))
                                            _v_uslfocre = Math.Round(reg_maxy_val, 4);

                                        //行程lsl
                                        var reg_minx_val = decimal.Parse(_getRegexString(@"XMin-X\.MinSet:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]);
                                        if ((reg_minx_val < _v_lslpostion) || (reg_minx_val != 0 && _v_lslpostion == 0))
                                            _v_lslpostion = Math.Round(reg_minx_val, 4);

                                        //行程usl

                                        var reg_maxx_val = decimal.Parse(_getRegexString(@"XMax-X\.MaxSet:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]);
                                        if ((reg_maxx_val > _v_uslpostion) || (reg_maxx_val != 0 && _v_uslpostion == 0))
                                            _v_uslpostion = Math.Round(reg_maxx_val, 4);

                                        if (_v_lslfocre > 0 || _v_uslfocre > 0 || _v_lslpostion > 0 || _v_uslpostion > 0)
                                        {
                                            //获取压机输出文件序号，例如将 OK-A125-001 -> 转换成 1  代表压力，位移 为一的压机上线限值
                                            var i = int.Parse(Regex.Match(_file.Name, pattern).Groups[1].Value);

                                            if (i >= 0 && i <= mesureStrs.Count)
                                            {
                                                var parts = mesureStrs[i-1]?.Split('|');
                                                if (parts?.Length >= 2)
                                                {
                                                    measurementDatas.Add(new MeasurementData
                                                    {
                                                        MeasurementName = parts[0],
                                                        MeasurementValueUSL = _v_uslfocre,
                                                        MeasurementValueLSL = _v_lslfocre
                                                    });

                                                    measurementDatas.Add(new MeasurementData
                                                    {
                                                        MeasurementName = parts[1],
                                                        MeasurementValueUSL = _v_uslpostion,
                                                        MeasurementValueLSL = _v_lslpostion
                                                    });
                                                }
                                            }
                                            else
                                            {
                                                measurementDatas.Add(new MeasurementData()
                                                {
                                                    MeasurementName = $"{i}压力",
                                                    MeasurementValueUSL = _v_uslfocre,
                                                    MeasurementValueLSL = _v_lslfocre,

                                                });
                                                measurementDatas.Add(new MeasurementData()
                                                {
                                                    MeasurementName = $"{i}位移",
                                                    MeasurementValueUSL = _v_uslpostion,
                                                    MeasurementValueLSL = _v_lslpostion,
                                                });
                                            }
                                           
                                            _logService.PressLog(0, $"读取到工位{stationNumber} -> 压力上下限:{_v_lslfocre}KN ~ {_v_uslfocre} KN 位移上下限: {_v_lslpostion}mm ~ {_v_uslpostion}mm");
                                        }
                                    }

                                }
                            }
                            strream.Close();
                            _fileopen.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        _logService.PressLog(2, $"压力采集{maindirname}{ex.Message}");
                        var pressListData = CreatePressDetailDto(stationNumber, maindirname, _dirpath, AcquistionState.Failed);
                        //新增失败数据到列表
                        InsertPressDetailDto(pressListData);
                        await _mediator.Publish(new DataListViewNotification() { PanelId = "PressDataGridViewTable", PressDetailDtos = pressDetailDtos }, cancellationToken);
                        //读取失败
                        return false;
                    }
                }
                //调用UpdateRecipeServices服务更新工站上限下限
                (bool isOk, string message) = await _recipeService.UpDateRecipeUpAndLowLimitAsync(stationNumber, measurementDatas);
                if (isOk)
                {
                    _logService.PressLog(0, $"{stationNumber}压机上下限同步成功");
                    var pressListData = CreatePressDetailDto(stationNumber, maindirname, _dirpath, AcquistionState.Sucess);
                    //新增成功数据到列表
                    InsertPressDetailDto(pressListData);
                    await _mediator.Publish(new DataListViewNotification() { PanelId = "PressDataGridViewTable", PressDetailDtos = pressDetailDtos }, cancellationToken);
                }
                else
                {
                    _logService.PressLog(2, $"{stationNumber}压机上下限同步失败；Error = {message}");
                    var pressListData = CreatePressDetailDto(stationNumber, maindirname, _dirpath, AcquistionState.Failed);
                    //新增失败数据到列表
                    InsertPressDetailDto(pressListData);
                    await _mediator.Publish(new DataListViewNotification() { PanelId = "PressDataGridViewTable", PressDetailDtos = pressDetailDtos }, cancellationToken);
                    return false;
                }

                //读取数据的文件移动到bak目录
                var _fileInfo = fileGroup.LastOrDefault();
                var bakdir = $"{_dirpath}/bak/{_fileInfo?.LastWriteTime.ToString("yyyy-MM-dd")}";
                if (!Directory.Exists(bakdir))
                    Directory.CreateDirectory(bakdir);

                foreach (var file in fileGroup)
                {
                    //将读取的文件移动到bak目录
                    file.MoveTo($"{bakdir}/" + file.Name, true);
                }

            }
            catch (Exception ex)
            {
                _logService.PressLog(2, $"{ex.Message}|{ex.StackTrace}");
                return false;
            }
            finally
            {              
                //压机日志输出
                _logService.PressLog(0, $"{dirinfo.Name}压力采集结束");
            }
            return true;
        }

        private static string _getRegexString(string pattern, string str, string rundefault = "")
        {
            string val = rundefault;
            try
            {
                var reg_maxx = new Regex(pattern).Match(str);
                if (reg_maxx.Success)
                    val = reg_maxx.Groups[0].Value;
            }
            catch { }
            return val;
        }   
       
        /// <summary>
        /// 当一个工位有多个压机设备时，根据设备编号获取工位名称
        /// 如果未找到设备/工位对应关系时，则默认将设备编号作为工位名称，压机输出的文件名为工位名称
        /// </summary>
        /// <param name="stationNumber"></param>
        /// <returns></returns>
        string _StationNuberMapp(string stationNumber)
        {
            var val = stationNumber.Replace(" ", "").Trim();

            string? stationName = string.Empty;  

            if (GlobalData.Params?.PressStation != null)
            {
                stationName = GlobalData.Params.PressStation
                    .SingleOrDefault(x => x.EquipmentNameOne == stationNumber || x.EquipmentNameTwo == stationNumber || x.EquipmentNameThree == stationNumber)?.StationName;
            }

            return stationName ?? val ; 
        }


        private void InsertPressDetailDto(PressDetailDto pressDetailDto)
        {
            //找到存在数据索引
            var existingIndex = pressDetailDtos.ToList().FindIndex(x => x.StationName == pressDetailDto.StationName);
            if (existingIndex >= 0)
            {
                // 如果存在，更新现有项
                pressDetailDtos[existingIndex] = pressDetailDto;
            }
            else
            {
                // 如果不存在，添加新项
                pressDetailDtos.Add(pressDetailDto);
            }
        }

        private PressDetailDto CreatePressDetailDto(string station, string equipment, string source, AcquistionState state)
        {
            Image icon;
            using (var ms = new MemoryStream(state == AcquistionState.Sucess ? Properties.Resources.Sucess : Properties.Resources.Error))
            {
                icon = Image.FromStream(ms);
            }
            return new PressDetailDto
            {
                StationName = station,
                EquimentName = equipment,
                FailFileSource = source,
                State = state,
                Icon = icon
            };
        }
    }
}
