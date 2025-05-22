using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperAndLowerLimitAcquisition.Helper;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Equipment
{
    public class DeviceInfoService
    {
        public ParamsSetting parmars { get; set; }
        public DeviceInfoService()
        {
            if (!File.Exists(GlobalData.ParamsSettingPath))
            {
                GlobalData.ParamsSettingPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConfigFile\\ParamsSetting.xml");
            }
            //反序列化配置文件，获取配置信息
            parmars = XmlSerializeHelper<ParamsSetting>.DeSerializeFronFile(GlobalData.ParamsSettingPath);
        }       
        public List<DevicesBaseInfo> GetDeviceType()
        {
            List<DevicesBaseInfo> devices = new List<DevicesBaseInfo>();
            if (string.IsNullOrEmpty(parmars.DeviceType))
            {
                return devices; 
            }
            if (parmars.DeviceType.Contains('|'))
            {               
                foreach (var item in parmars.DeviceType.Split('|'))
                {
                    devices.Add(GetDevicesBaseInfo(item));
                }
                return devices;
            }
            else
            {
                devices.Add(GetDevicesBaseInfo(parmars.DeviceType));              
                return devices;
            }
        }

        private DevicesBaseInfo GetDevicesBaseInfo(string deviceName)
        {
            switch (deviceName)
            {
                case "压机":
                    return new DevicesBaseInfo
                    {
                        DeviceName = "压机数量",
                        DevicesTotalQuantity = 0,
                        DeviceNormalOperation = 0,
                        DeviceFaultCount = 0,
                        DeviceDescription = "压机数采概览"
                    };                   
                case "拧紧枪":
                    return new DevicesBaseInfo
                    {
                        DeviceName = "拧紧枪数量",
                        DevicesTotalQuantity = 0,
                        DeviceNormalOperation = 0,
                        DeviceFaultCount = 0,
                        DeviceDescription = "拧紧枪数采概览"
                    };                  
                case "气密仪":
                    return new DevicesBaseInfo
                    {
                        DeviceName = "气密数量",
                        DevicesTotalQuantity = 0,
                        DeviceNormalOperation = 0,
                        DeviceFaultCount = 0,
                        DeviceDescription = "气密数采概览"
                    };                  
                default:
                    {
                        //将总设备描述添加到列表中
                         return new DevicesBaseInfo
                        {
                            DeviceName = "数采设备总数",
                            DeviceTypeCount = 0,
                            DevicesTotalQuantity = 0
                        };                      
                    }
            }
        }
    }
}
