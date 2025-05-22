using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class FISWorkOrder
{
    public long Id { get; set; }

    public long? WorkOrderId { get; set; }

    public int? ProcessStepId { get; set; }

    public int? StationId { get; set; }

    public decimal? TotalPassQuantity { get; set; }

    public decimal? TotalScrapQuantity { get; set; }

    public decimal? TotalFailQuantity { get; set; }

    public decimal? TotalInputProducts { get; set; }

    public decimal? TotalGoodProductsQuantity { get; set; }

    public decimal? AverageCycleTime { get; set; }

    public decimal? OEE { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public virtual ProcessStep? ProcessStep { get; set; }

    public virtual Station? Station { get; set; }

    public virtual WorkOrder? WorkOrder { get; set; }
}
