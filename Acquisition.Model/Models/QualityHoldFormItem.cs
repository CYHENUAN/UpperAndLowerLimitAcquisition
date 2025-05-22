using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class QualityHoldFormItem
{
    public long Id { get; set; }

    public int? QualityHoldFormId { get; set; }

    public string? ObjectRegex { get; set; }

    /// <summary>
    /// 1:Hold,2:Unhold,-1:Deleted
    /// </summary>
    public int? State { get; set; }

    public DateTime? UnholdDateTime { get; set; }

    public int? UnholdEditorId { get; set; }

    public virtual QualityHoldForm? QualityHoldForm { get; set; }

    public virtual User? UnholdEditor { get; set; }
}
