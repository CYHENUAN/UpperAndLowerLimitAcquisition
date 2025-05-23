using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperAndLowerLimitAcquisition.Controls;

namespace UpperAndLowerLimitAcquisition.Model
{
    [Serializable]
    [DefaultProperty("基础参数设置")]
    public class ParamsSetting
    {
        //-----------------压机参数设置-----------------
        [DisplayName("文件路径"), Category("压机设置")]
        public string? PressFilePath { get; set; }

        [Editor(typeof(EquipmentCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [DisplayName("压机工站"), Category("压机设置")]
        public List<CollectionClass> PressStation { get; set; } = new List<CollectionClass>();
        [DisplayName("是否启用压机采集"), Category("压机设置")]
        public IsEnable PressIsEnable { get; set; }
        [DisplayName("压机采集频率，默认12小时采集一次"), Category("压机设置")]
        public int PressReadFrequency { get; set; } = 12;

        // -----------------拧紧枪参数设置-----------------
        [DisplayName("拧紧工站"), Category("拧紧枪参数设置")]
        public string? TightenStation { get; set; }
        [DisplayName("是否启用拧紧枪采集"), Category("拧紧枪参数设置")]
        public IsEnable TightenIsEnable { get; set; }
           
        // -----------------气密仪参数设置-----------------
        [DisplayName("气密仪工站"), Category("气密仪参数设置")]
        public string? AirtightStation { get; set; }
        [DisplayName("是否启用气密仪采集"), Category("气密仪参数设置")]
        public IsEnable AirIsEnable { get; set; }
        // -----------------其他参数设置-----------------

        [DisplayName("采集设备种类"), Category("其他参数设置")]
        public string? DeviceType { get; set; }
        [DisplayName("日志输出路径"), Category("其他参数设置")]
        public string LogPath { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        [DisplayName("日志过期时间"), Category("其他参数设置")]
        public int LogRetentionDays { get; set; }
    }
}
