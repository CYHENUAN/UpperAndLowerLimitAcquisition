using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class QualityUnHoldForm
{
    public int Id { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public string FormNumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Comment { get; set; }

    /// <summary>
    /// 1:ContainerRegexHold,2:ContainerNumberHold,3:PartSerialNumberRegexHold,4:PartSerialNumberHold
    /// </summary>
    public int HoldType { get; set; }

    /// <summary>
    /// 1:Active,0:Deactive,-1:Deleted
    /// </summary>
    public int State { get; set; }

    public virtual User? Creator { get; set; }

    public virtual ICollection<QualityUnHoldFormItem> QualityUnHoldFormItems { get; set; } = new List<QualityUnHoldFormItem>();
}
