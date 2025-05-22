using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class QualityUnHoldFormItem
{
    public long Id { get; set; }

    public int? QualityUnHoldFormId { get; set; }

    public string? ObjectRegex { get; set; }

    /// <summary>
    /// 1:Hold,2:Unhold,-1:Deleted
    /// </summary>
    public int? State { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public virtual User? Creator { get; set; }

    public virtual QualityUnHoldForm? QualityUnHoldForm { get; set; }
}
