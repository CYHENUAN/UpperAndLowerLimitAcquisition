using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class CollectionClass
    {
        [Category("基本属性"), DisplayName("工站名称")]
        public string? StationName { get; set; }

        [Category("基本属性"), DisplayName("设备名称1")]
        public string? EquipmentNameOne { get; set; }
        [Category("基本属性"), DisplayName("设备名称2")]
        public string? EquipmentNameTwo { get; set; }
        [Category("基本属性"), DisplayName("设备名称3")]
        public string? EquipmentNameThree { get; set; }

        public override string ToString()
        {
            return StationName ?? string.Empty;  
        }
    }

    public class PressMeasurementData
    {
        [Category("基本属性"), DisplayName("工站名称")]
        public string? StationName { get; set; }

        [Category("基本属性"), DisplayName("检测项1")]
        public string? MeasurementOne { get; set; }
        [Category("基本属性"), DisplayName("检测项2")]
        public string? MeasurementTwo { get; set; }
        [Category("基本属性"), DisplayName("检测项3")]
        public string? MeasurementThree { get; set; }
        [Category("基本属性"), DisplayName("检测项4")]
        public string? MeasurementFour { get; set; }
        [Category("基本属性"), DisplayName("检测项5")]
        public string? MeasurementFive { get; set; }

        public override string ToString()
        {
            return StationName ?? string.Empty;
        }
    }
}
