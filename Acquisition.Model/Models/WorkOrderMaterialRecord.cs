using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class WorkOrderMaterialRecord
{
    public long Id { get; set; }

    public long WorkOrderProcessRecordId { get; set; }

    public long ContainerId { get; set; }

    public DateTime SetupDateTime { get; set; }

    public decimal? Quantity { get; set; }

    public int? UnitId { get; set; }

    public int OperatorId { get; set; }

    public virtual Container Container { get; set; } = null!;

    public virtual User Operator { get; set; } = null!;

    public virtual Unit? Unit { get; set; }

    public virtual WorkOrderProcessRecord WorkOrderProcessRecord { get; set; } = null!;
}
