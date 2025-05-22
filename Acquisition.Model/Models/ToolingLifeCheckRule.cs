using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ToolingLifeCheckRule
{
    public int Id { get; set; }

    public string RuleCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int LifeCalculationTypeUnitId { get; set; }

    public decimal WarningLifeThreshold { get; set; }

    public decimal ExpirationLifeThreshold { get; set; }

    public int State { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual Unit LifeCalculationTypeUnit { get; set; } = null!;

    public virtual ICollection<ToolingLife> ToolingLives { get; set; } = new List<ToolingLife>();

    public virtual ICollection<ToolingType_ToolingLifeCheckRule> ToolingType_ToolingLifeCheckRules { get; set; } = new List<ToolingType_ToolingLifeCheckRule>();
}
