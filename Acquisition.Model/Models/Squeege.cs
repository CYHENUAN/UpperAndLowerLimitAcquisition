using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

/// <summary>
/// 刮刀
/// </summary>
public partial class Squeege
{
    public int Id { get; set; }

    public long ToolingId { get; set; }

    public int SqueegeTypeId { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public string? EditDateTime { get; set; }

    public virtual ICollection<SqueegeEventHistory> SqueegeEventHistories { get; set; } = new List<SqueegeEventHistory>();

    public virtual SqueegeType SqueegeType { get; set; } = null!;
}
