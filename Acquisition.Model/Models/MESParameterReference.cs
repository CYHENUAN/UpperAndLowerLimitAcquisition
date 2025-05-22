using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MESParameterReference
{
    public int Id { get; set; }

    /// <summary>
    /// 1:ServerParameter,2:CompanyParameter,3:FactoryParameter,4:AreaParameter,5:CellParameter,6:StationGroupParameter,7:StationParameter
    /// </summary>
    public int ParameterType { get; set; }

    public string? ParameterCode { get; set; }

    public string ParameterName { get; set; } = null!;

    /// <summary>
    /// 1:Object,2:String,3:Boolean,4:Integer,5:Long,6:Float,7:Double,8:Decimal
    /// </summary>
    public int ParameterValueType { get; set; }

    public string? Description { get; set; }

    /// <summary>
    /// 分隔符用|
    /// </summary>
    public string? AllowedValues { get; set; }

    public string? DefaultValue { get; set; }

    public bool IsDynamic { get; set; }

    public bool IsCustomerSpecific { get; set; }

    public string? CustomerCode { get; set; }

    public virtual ICollection<CompanyParameter> CompanyParameters { get; set; } = new List<CompanyParameter>();

    public virtual ICollection<StationParameter> StationParameters { get; set; } = new List<StationParameter>();
}
