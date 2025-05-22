using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ContainerLabelPrintRecord
{
    public long Id { get; set; }

    public string ContainerNumber { get; set; } = null!;

    public DateTime PrintDateTime { get; set; }

    public string MaterialNumber { get; set; } = null!;

    public string? MaterialName { get; set; }

    public string? MaterialSpecification { get; set; }

    public string SupplierCode { get; set; } = null!;

    public string? SupplierName { get; set; }

    public string PurchaseOrderCode { get; set; } = null!;

    public string POItemNnumber { get; set; } = null!;

    public decimal? MPQ { get; set; }

    public decimal Quantity { get; set; }

    public string UnitName { get; set; } = null!;

    public string? OperatorAccount { get; set; }

    public string? OperatorName { get; set; }

    public string BatchNumber { get; set; } = null!;

    /// <summary>
    /// 1:NewPrint,2:RePrint
    /// </summary>
    public int? PrintType { get; set; }

    public string? StationNumber { get; set; }
}
