using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ToolingType_ToolingLifeCheckRule
{
    public int Id { get; set; }

    public int ToolingTypeId { get; set; }

    public int ToolingLifeCheckRuleId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    /// <summary>
    /// 0:Deactive,1:Active
    /// </summary>
    public int State { get; set; }

    public virtual ToolingLifeCheckRule ToolingLifeCheckRule { get; set; } = null!;

    public virtual ToolingType ToolingType { get; set; } = null!;
}
