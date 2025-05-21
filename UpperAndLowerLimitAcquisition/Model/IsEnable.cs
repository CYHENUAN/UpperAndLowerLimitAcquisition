using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperAndLowerLimitAcquisition.Model
{
    /// <summary>
    ///设备是否启用
    /// </summary>
    public enum IsEnable
    {
        True,
        False,
    }
    /// <summary>
    /// 设备类型
    /// </summary>
    public enum EquipmentType
    {
        //压机
        Press,
        //拧紧枪
        Tighten,
        //气密仪
        Air
    }

    public enum LogLevel
    {
        Info = 0,
        Error =1,
        Debug = 2,
        Warn = 3,
        Fatal =4
    }


}
