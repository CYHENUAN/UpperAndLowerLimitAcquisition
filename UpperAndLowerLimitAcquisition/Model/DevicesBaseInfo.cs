using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class DevicesBaseInfo
    {
        public string DeviceName { get; set; } //设备名称
        public int DeviceTypeCount { get; set; } //设备数量
        public int DevicesTotalQuantity { get; set; } //设备总数量
        public int DeviceNormalOperation { get; set; } //设备正常运行数量
        public int DeviceFaultCount { get; set; } //设备故障数量
        public string DeviceDescription { get; set; } //设备描述
    }
}
