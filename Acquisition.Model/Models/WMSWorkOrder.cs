using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class WMSWorkOrder
{
    public long Id { get; set; }

    public string WorkOrderNumber { get; set; } = null!;

    public int MaterialId { get; set; }

    public int UnitId { get; set; }

    public decimal PlannedQuantity { get; set; }

    public decimal? ActualBuiltQuantity { get; set; }

    public DateTime PlannedStartDateTime { get; set; }

    public DateTime PlannedFinishDateTime { get; set; }

    public DateTime? ActualStartDateTime { get; set; }

    public DateTime? ActualFinishedDateTime { get; set; }

    public int LocationId { get; set; }

    public int CellId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int State { get; set; }

    public virtual Cell Cell { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual Material Material { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
