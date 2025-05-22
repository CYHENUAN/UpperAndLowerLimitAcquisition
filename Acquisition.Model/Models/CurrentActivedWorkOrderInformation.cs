using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class CurrentActivedWorkOrderInformation
{
    public long Id { get; set; }

    public long WorkOrderId { get; set; }

    public int StationId { get; set; }

    public int CellId { get; set; }

    public int ProcessStepId { get; set; }

    public DateTime ActiveDateTime { get; set; }

    public int ActiveUserId { get; set; }

    public virtual User ActiveUser { get; set; } = null!;

    public virtual Cell Cell { get; set; } = null!;

    public virtual ProcessStep ProcessStep { get; set; } = null!;

    public virtual Station Station { get; set; } = null!;

    public virtual WorkOrder WorkOrder { get; set; } = null!;
}
