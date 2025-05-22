using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

/// <summary>
/// 属性绑定数据
/// </summary>
public partial class AttributeDataRecord
{
    public long Id { get; set; }

    /// <summary>
    /// 被附加属性的对象实体的类型名,1:PartSerialNumber,2:WorkOrder,3:Container
    /// </summary>
    public int EntityType { get; set; }

    /// <summary>
    /// 1
    /// </summary>
    public long EntityId { get; set; }

    public string? EntityUniqueCode { get; set; }

    public int? AssignedStationNumberId { get; set; }

    public int AttributeTypeId { get; set; }

    public string AttributeValue { get; set; } = null!;

    /// <summary>
    /// 1:API,2:ManualInput
    /// </summary>
    public int? AssignMethod { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int CreatorId { get; set; }

    public virtual Station? AssignedStationNumber { get; set; }

    public virtual AttributeType AttributeType { get; set; } = null!;

    public virtual User Creator { get; set; } = null!;
}
