using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperAndLowerLimitAcquisition.Helper;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Services
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

        //获取单类型设备数量
        private int GetDeviceCount(string deviceName)
        {
            int count = 0;
            if (string.IsNullOrEmpty(deviceName))
            {
                return count;
            }
            if (deviceName.Contains('|'))
            {
                count = deviceName.Split('|').Length;
                return count;
            }
            else
            {
                count = 1;
                return count;
            }          
        }
        //获取多个设备的总数量
        private int GetDevicesTotalQuantity(ParamsSetting paramsSetting)
        {
            int count = 0;
            count += paramsSetting.PressStation.Count;
            count += GetDeviceCount(paramsSetting.TightenStation ?? "默认");
            count += GetDeviceCount(paramsSetting.AirtightStation ?? "默认");
            return count;
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
                        DevicesTotalQuantity = parmars.PressStation.Count,
                        DeviceNormalOperation = 0,
                        DeviceFaultCount = 0,
                        DeviceDescription = "压机数采概览"
                    };                   
                case "拧紧枪":
                    return new DevicesBaseInfo
                    {
                        DeviceName = "拧紧枪数量",
                        DevicesTotalQuantity = GetDeviceCount(parmars.TightenStation),
                        DeviceNormalOperation = 0,
                        DeviceFaultCount = 0,
                        DeviceDescription = "拧紧枪数采概览"
                    };                  
                case "气密仪":
                    return new DevicesBaseInfo
                    {
                        DeviceName = "气密数量",
                        DevicesTotalQuantity = GetDeviceCount(parmars.AirtightStation),
                        DeviceNormalOperation = 0,
                        DeviceFaultCount = 0,
                        DeviceDescription = "气密数采概览"
                    };                  
                default:
                    {
                        //将总设备描述添加到列表中
                         return new DevicesBaseInfo
                        {
                            DeviceName = "数采设备种类",
                            DeviceTypeCount = GetDeviceCount(parmars.DeviceType),
                            DevicesTotalQuantity = GetDevicesTotalQuantity(parmars)
                        };                      
                    }
            }
        }
    }
}
