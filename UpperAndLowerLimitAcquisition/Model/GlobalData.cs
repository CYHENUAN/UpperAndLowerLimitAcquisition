using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using UpperAndLowerLimitAcquisition.Helper;

namespace UpperAndLowerLimitAcquisition.Model
{
    public static class GlobalData
    {
        public static string ParamsSettingPath { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConfigFile\\ParamsSetting.xml");

        public static ParamsSetting? Params { get; set; }

        public static string? LogPath {get; set;}

        public static int TotalCount { get; set; } 
        public static int SuccessCount { get; set; }
        public static int FailedCount { get; set; }

        public static Dictionary<string, UpdateLabelClass> LabelUpdates { get; set; } = new Dictionary<string, UpdateLabelClass>();

        public static void initParams()
        {
            //反序列化配置文件，获取配置信息
            Params = XmlSerializeHelper<ParamsSetting>.DeSerializeFronFile(GlobalData.ParamsSettingPath);

            //如果日志文件没有设置，则创建默认配置文件
            if (string.IsNullOrEmpty(Params.LogPath))
            {
                LogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            }
            else
            {
                //如果日志文件路径已设置但不存在，则创建           
                if (!File.Exists(Params.LogPath))
                {
                    Directory.CreateDirectory(Params.LogPath);
                    LogPath = Params.LogPath;
                }
                else
                {
                    LogPath = Params.LogPath;
                }
            }
           
        }
    }
}
