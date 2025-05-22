using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class BOMItem
{
    public int Id { get; set; }

    public int BOMHeadId { get; set; }

    public int MaterialId { get; set; }

    public string? Designator { get; set; }

    public decimal Quantity { get; set; }

    public int StationGroupId { get; set; }

    public bool IsNeedSetupCheck { get; set; }

    public int Layer { get; set; }

    public int Unit { get; set; }

    public bool IsAlternative { get; set; }

    public int Version { get; set; }

    /// <summary>
    /// 0=Batch;1=Unique
    /// </summary>
    public bool IsUnique { get; set; }

    public bool? IsTooling { get; set; }

    public virtual BOMHead BOMHead { get; set; } = null!;

    public virtual Material Material { get; set; } = null!;

    public virtual StationGroup StationGroup { get; set; } = null!;
}
