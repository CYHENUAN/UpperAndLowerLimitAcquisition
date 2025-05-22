using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Acquisition.IService;
using UpperAndLowerLimitAcquisition.Helper;
using UpperAndLowerLimitAcquisition.Log;
using UpperAndLowerLimitAcquisition.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UpperAndLowerLimitAcquisition.Equipment.Press
{
    public class PressService
    {
        static Dictionary<string, string> _stationmappDict = new Dictionary<string, string>();
        private readonly LogService _logService;
        private readonly IUpdateRecipeService _recipeService;
        public PressService(LogService logService, IUpdateRecipeService recipeService)
        {
            _logService = logService;
            _recipeService = recipeService;
        }
        public Task<bool> TryReadFileAsync(DirectoryInfo dirinfo)
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

                //压机日志输出
                _logService.PressLog(0, $"{stationNumber}压力采集准备开始，采集设备：{maindirname}");
                
                var filemove = new List<FileInfo>();//要移除的文件
                var dirsons = dirinfo.GetDirectories().Where(w => w.Name.IsDateTime()).OrderBy(w => w.LastWriteTime).ToList();
                
                foreach (var dirson in dirsons)
                {
                    if (dirson.GetFiles().Count() == 0 && dirson.Name.IsDateTime() && dirson.Name != DateTime.Now.ToString("yyyy-MM-dd"))
                    {//如果文件夹为空切不是今天的则删除文件夹
                        dirson.Delete();
                        //   Log($"压力采集{maindirname}", $"删除空文件夹{dirson.FullName}");
                        continue;
                    }

                    //获取每组压机最新的文件
                    //以前缀OK-A125-001分组找到每组最新的文件
                    //提取编号部分
                    string pattern = @$"OK-{Regex.Escape(maindirname)}-(\d{{3}})"; 

                    var fileGroup = dirson.GetFiles("*.csv")
                       .Where(f => Regex.IsMatch(f.Name, pattern))
                       .GroupBy(f => Regex.Match(f.Name, pattern).Value)
                       .Select(g => g.OrderByDescending(p => p.LastWriteTime).First())
                       .OrderBy(f => int.Parse(Regex.Match(f.Name, pattern).Groups[1].Value))
                       .ToList();

                    foreach(var _file in fileGroup)
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

                                                _logService.PressLog(0, $"读取到工位{stationNumber} -> 压力上下限:{_v_lslfocre}KN ~ {_v_uslfocre} KN 位移上下限: {_v_lslpostion}mm ~ {_v_uslpostion}mm");
                                            }
                                        }

                                    }
                                }
                                strream.Close();
                                _fileopen.Close();
                            }
                            //移除
                            var bakdir = $"{_dirpath}/bak/{_file.LastWriteTime.ToString("yyyy-MM-dd")}";
                            if (!Directory.Exists(bakdir))
                                Directory.CreateDirectory(bakdir);
                            _file.MoveTo($"{bakdir}/" + _file.Name, true);


                            //调用UpdateRecipeServices服务更新工站上限下限

                        }
                        catch (Exception ex)
                        {
                            _logService.PressLog(2, $"压力采集{maindirname}{ex.Message}");
                            if (_file?.Directory != null)
                            {
                                _file.MoveTo($"{_dirpath}/error/{_file.Directory.Name}_{_file.Name}");
                            }
                            else
                            {
                                _logService.PressLog(2, $"压力采集{maindirname}文件目录为空，无法移动文件: {_file?.FullName}");
                            }
                            //读取失败
                            return Task.FromResult(false);
                        }
                    }                                                   
                }
            }
            catch (Exception ex)
            {
                _logService.PressLog(2, $"{ex.Message}|{ex.StackTrace}");
                return Task.FromResult(false);
            }
            finally
            {
                //压机日志输出
                _logService.PressLog(0, $"{dirinfo.Name}压力采集结束");
            }

            return Task.FromResult(true);

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
    }
}
