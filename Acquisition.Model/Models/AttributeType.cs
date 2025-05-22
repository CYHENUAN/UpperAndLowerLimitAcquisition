using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

/// <summary>
/// 附加属性类型
/// </summary>
public partial class AttributeType
{
    public int Id { get; set; }

    public string AttributeCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    /// <summary>
    /// 被附加属性的对象实体的类型名,1:PartSerialNumber,2:WorkOrder,3:Container
    /// </summary>
    public int AttributeEntityType { get; set; }

    public bool IsUnique { get; set; }

    public int State { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public virtual ICollection<AttributeDataRecord> AttributeDataRecords { get; set; } = new List<AttributeDataRecord>();

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }
}
