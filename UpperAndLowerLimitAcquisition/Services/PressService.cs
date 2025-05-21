using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UpperAndLowerLimitAcquisition.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UpperAndLowerLimitAcquisition.Services
{
    public class PressService
    {
        static Dictionary<string, string> _stationmappDict = new Dictionary<string, string>();
      /*  public Task<bool> TryReadFileAsync(DirectoryInfo dirinfo)
        {
            try
            {
                var _dirpath = dirinfo.FullName;
                if (!Directory.Exists($"{_dirpath}/bak"))
                    Directory.CreateDirectory($"{_dirpath}/bak");

                if (!Directory.Exists($"{_dirpath}/error"))
                    Directory.CreateDirectory($"{_dirpath}/error");

                var maindirname = dirinfo.Name.TrimAll();

                var stationNumber = _StationNuberMapp(maindirname);
                //   Log($"压力采集{maindirname}", $"开始采集{maindirname}");
                var filemove = new List<FileInfo>();//要移除的文件
                var dirsons = dirinfo.GetDirectories().Where(w => w.Name.IsDateTime()).OrderBy(w => w.LastWriteTime).ToList();
                dirsons.Add(dirinfo);
               // var newcurveDataList = new List<PartMeasurementDataRecordAndPartProcessRecordDto>();
                foreach (var dirson in dirsons)
                {
                    if (dirson.GetFiles().Count() == 0 && dirson.Name.IsDateTime() && dirson.Name != DateTime.Now.ToString("yyyy-MM-dd"))
                    {//如果文件夹为空切不是今天的则删除文件夹
                        dirson.Delete();
                        //   Log($"压力采集{maindirname}", $"删除空文件夹{dirson.FullName}");
                        continue;
                    }
                    foreach (var _file in dirson.GetFiles("*.csv").Where(w => (DateTime.Now - w.LastWriteTime).TotalSeconds > 10).Take(_FileTop).OrderBy(w => w.LastWriteTime))
                    {
                        // Log($"压力采集{maindirname}", $"读取到{_file.FullName}");
                        try
                        {
                            var _sn_proto = "";
                            var _sn = "";
                            var _booktime = DateTime.Now;
                            var _v_times = new List<decimal>();
                            var _v_x_postion = new List<decimal>();//行程
                            var _v_y_force = new List<decimal>();//压力
                            var _v_maxforce = 0M;//最大压力
                            var _v_minforce = 0M;//最小压力
                            var _v_averageforce = 0M;//均值压力
                            var _v_xmaxforce = 0M;//最终压力
                            var _v_uslfocre = 0M;//上限
                            var _v_lslfocre = 0M;//下限

                            var _v_maxpostion = 0M;//最大位移
                            var _v_minpostion = 0M;//最小位移
                            var _v_averagepostion = 0M;//均值位移

                            var _v_uslpostion = 0M;//位移上限
                            var _v_lslpostion = 0M;//位移下限
                            var _v_refconfs = new JArray();//判定标准
                            var _Result = "";
                            var _productname = "";//程序名称
                            using (var _fileopen = new FileStream(_file.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
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

                                    switch (f_index)
                                    {
                                        case 7:
                                            _sn_proto = _getSplitstring(f_str, ",", 1);
                                            _sn = "";//解析SN
                                            var _snvals = _sn_proto.Split('-');
                                            var _sn_splitindex = 8;
                                            if (_sn_proto.IsNotNull() && _snvals.Length > _sn_splitindex)
                                            {
                                                _sn = _snvals[_snvals.Length - 1];
                                                var _sns = _sn.Split('-');//通个最后一个值去匹配
                                                                          //程序名
                                                _productname = _snvals[2];
                                            }

                                            break;
                                        case 11:
                                            _booktime = System.DateTime.ParseExact(_getSplitstring(f_str, ",", 1), "yyyy-MM-dd-HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                                            break;
                                        case 111:
                                            _Result = _getSplitstring(f_str, ",", 1) == "0" ? "NG" : "OK";
                                            break;
                                        default:
                                            if (f_str.IsNotNull())
                                            {
                                                if (f_str.StartsWith("Curve") && f_str.IndexOf("ForceMax_Force") > -1)
                                                {
                                                    _v_maxforce = _getSplitdecimal(f_str, ",", 1);//最大压力

                                                }
                                                else if (f_str.StartsWith("Curve") && f_str.IndexOf("ForceMin_Force") > -1)
                                                {
                                                    _v_minforce = _getSplitdecimal(f_str, ",", 1);//最小压力

                                                }

                                                else if (f_str.StartsWith("Curve") && f_str.IndexOf("ForceAverage") > -1)
                                                {
                                                    _v_averageforce = _getSplitdecimal(f_str, ",", 1);//均值压力

                                                }
                                                else if (f_str.StartsWith("Curve") && f_str.IndexOf("Xmax_Force") > -1)
                                                {
                                                    _v_xmaxforce = _getSplitdecimal(f_str, ",", 1);//最终压力

                                                }
                                                if (f_str.StartsWith("Curve") && f_str.IndexOf("Xmax_X") > -1)
                                                {
                                                    _v_maxpostion = _getSplitdecimal(f_str, ",", 1);//最大行程

                                                }
                                                else if (f_str.StartsWith("Curve") && f_str.IndexOf("Xmin_X") > -1)
                                                {
                                                    _v_minpostion = _getSplitdecimal(f_str, ",", 1);//最小行程

                                                }

                                                else if (f_str.StartsWith("Curve") && f_str.IndexOf("XAverage") > -1)
                                                {
                                                    _v_averagepostion = _getSplitdecimal(f_str, ",", 1);//均值行程

                                                }
                                                else if (f_index >= 52 && f_index <= 69)
                                                { //判定标准配置区

                                                    if (f_str.Replace(@"""", "").IsNotNull())
                                                    {
                                                        var c = new JArray();
                                                        var x1 = Math.Round(float.Parse(_getRegexString(@"Point0X:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]), 4);
                                                        var x2 = Math.Round(float.Parse(_getRegexString(@"Point1X:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]), 4);
                                                        var x3 = Math.Round(float.Parse(_getRegexString(@"Point2X:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]), 4);
                                                        var x4 = Math.Round(float.Parse(_getRegexString(@"Point3X:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]), 4);
                                                        var y1 = Math.Round(float.Parse(_getRegexString(@"Point0Y:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]), 4);
                                                        var y2 = Math.Round(float.Parse(_getRegexString(@"Point1Y:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]), 4);
                                                        var y3 = Math.Round(float.Parse(_getRegexString(@"Point2Y:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]), 4);
                                                        var y4 = Math.Round(float.Parse(_getRegexString(@"Point3Y:,-?\d+(\.\d+)?", f_str, "0,0").Split(",")[1]), 4);
                                                        c.Add(new JObject { { "x", x1 }, { "y", y1 } });
                                                        c.Add(new JObject { { "x", x2 }, { "y", y2 } });
                                                        c.Add(new JObject { { "x", x3 }, { "y", y3 } });
                                                        c.Add(new JObject { { "x", x4 }, { "y", y4 } });

                                                        _v_refconfs.Add(c);
                                                    }
                                                }
                                                else if (f_index >= 113 && f_index <= 119)
                                                {
                                                    _v_uslfocre = 0M;//上限
                                                    _v_lslfocre = 0M;//下限
                                                    _v_uslpostion = 0M;//位移上限
                                                    _v_lslpostion = 0M;//位移下限
                                                    var _Eoindex = f_index - 113;
                                                    if (f_str.IsNotNull())
                                                    {
                                                        //获取判定结果区域数据
                                                        //压力lsl
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
                                                            Log($"工位{stationNumber}读取到EO{_Eoindex} 程序:{_productname} SN:{_sn}压力上下限:{_v_lslfocre}KN ~ {_v_uslfocre} KN 位移上下限: {_v_lslpostion}mm ~ {_v_uslpostion}mm", true);
                                                    }

                                                }
                                                else if (f_index >= 150)
                                                {
                                                    _v_times.Add(_getSplitdecimal(f_str, ",", 0));
                                                    _v_x_postion.Add(_getSplitdecimal(f_str, ",", 1));
                                                    _v_y_force.Add(_getSplitdecimal(f_str, ",", 2));
                                                }

                                            }
                                            break;

                                    }
                                }
                                strream.Close();
                                _fileopen.Close();
                            }
                            //移除
                            var bakdir = $"{_dirpath}/bak/{_file.LastWriteTime.ToString("yyy-MM-dd")}";
                            if (!Directory.Exists(bakdir))
                                Directory.CreateDirectory(bakdir);
                            _file.MoveTo($"{bakdir}/" + _file.Name, true);

                        }
                        catch (Exception ex)
                        {
                            Log($"压力采集{maindirname}", $"{ex.Message}|{ex.StackTrace}|error{_file.FullName}");
                            _file.MoveTo($"{_dirpath}/error/{_file.Directory.Name}_{_file.Name}");
                        }

                    }
                }

            }
            catch (Exception direrr)
            { }

            return Task.FromResult(true);

        }*/



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

        private decimal _getSplitdecimal(string valstring, string splitkey, int index = 0)
        {
            decimal getval = 0;
            try
            {
                var str = _getSplitstring(valstring, splitkey, index);
                getval = Math.Round(Convert.ToDecimal(str), 4);
            }
            catch (Exception ex)
            { 
            }

            return getval;
        }

        private string _getSplitstring(string valstring, string splitkey, int index = 0)
        {
            var getval = string.Empty;
            try
            {
                var vals = valstring.Split(splitkey);
                getval = vals[index].Replace("\"", "");
            }
            catch (Exception ex)
            { }

            return getval;
        }

       /* private string _StationNuberMapp(string stationNumber)
        {
            var val = stationNumber.TrimAll();
            try
            {
                if (_stationmappDict.Count == 0)
                {
                    var configval = GlobalData.Params.PressStation;
                    if (configval.IsNotNull())
                    {
                        foreach (var item in configval.Split(','))
                        {
                            var snm = item.Split('|');
                            foreach (var _number in snm)
                            {
                                if (!_stationmappDict.ContainsKey(_number))
                                    _stationmappDict.Add(_number, snm[0]);
                            }
                        }
                    }
                }

                if (_stationmappDict.ContainsKey(stationNumber))
                    val = _stationmappDict[stationNumber];
            }
            catch { }
            return val;

        }*/
    }
}
