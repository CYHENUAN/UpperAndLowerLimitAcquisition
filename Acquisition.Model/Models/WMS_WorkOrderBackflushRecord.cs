using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class WMS_WorkOrderBackflushRecord
{
    public long Id { get; set; }

    public string WorkOrderCode { get; set; } = null!;

    public DateTime BackflushDateTime { get; set; }

    public string MaterialCode { get; set; } = null!;

    public string? UnitCode { get; set; }

    public decimal ReportQuantity { get; set; }

    public string? AreaCode { get; set; }

    public string? LineCode { get; set; }

    public string? BatchNumber { get; set; }

    public int Status { get; set; }

    public DateTime CreationDateTime { get; set; }

    public DateTime? Stamp { get; set; }

    public DateTime? ProcessedDateTime { get; set; }

    public int OperationType { get; set; }
}
