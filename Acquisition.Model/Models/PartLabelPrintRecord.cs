using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PartLabelPrintRecord
{
    public long Id { get; set; }

    public string WorkOrderCode { get; set; } = null!;

    public string PartSerialNumber { get; set; } = null!;

    public string MaterialNumber { get; set; } = null!;

    public string MaterialName { get; set; } = null!;

    public string? MaterialSpecification { get; set; }

    public decimal Quantity { get; set; }

    public DateTime PrintDateTime { get; set; }

    public string? OperatorAccount { get; set; }

    public string? OperatorName { get; set; }

    public string? StationNumber { get; set; }

    public string? UnitName { get; set; }

    /// <summary>
    /// 1:NewPrint,2:RePrint
    /// </summary>
    public int? PrintType { get; set; }
}
