using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ProductInStockingFormItem
{
    public int Id { get; set; }

    public int ProductInStockFormId { get; set; }

    public int? ItemNumber { get; set; }

    public long? WorkOrderId { get; set; }

    public int? UnitId { get; set; }

    public int? MaterialId { get; set; }

    public decimal RequestQuantity { get; set; }

    public decimal ScannedQuantity { get; set; }

    public int? SourceLocationId { get; set; }

    public int? TargetLocationId { get; set; }

    public int? State { get; set; }

    public virtual Material? Material { get; set; }

    public virtual ProductInStockingForm ProductInStockForm { get; set; } = null!;

    public virtual Location? SourceLocation { get; set; }

    public virtual Location? TargetLocation { get; set; }

    public virtual Unit? Unit { get; set; }

    public virtual WorkOrder? WorkOrder { get; set; }
}
