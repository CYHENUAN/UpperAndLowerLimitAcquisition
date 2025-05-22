using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

/// <summary>
/// 工装类型
/// </summary>
public partial class ToolingType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Specification { get; set; }

    public int? State { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? MaterialId { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual Material? Material { get; set; }

    public virtual ICollection<ToolingType_ToolingLifeCheckRule> ToolingType_ToolingLifeCheckRules { get; set; } = new List<ToolingType_ToolingLifeCheckRule>();

    public virtual ICollection<Tooling> Toolings { get; set; } = new List<Tooling>();
}
