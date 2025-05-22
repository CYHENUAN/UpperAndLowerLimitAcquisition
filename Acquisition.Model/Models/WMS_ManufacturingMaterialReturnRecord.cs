using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class WMS_ManufacturingMaterialReturnRecord
{
    public long Id { get; set; }

    public string? WorkOrderCode { get; set; }

    public string MaterialCode { get; set; } = null!;

    public string? ContainerNumber { get; set; }

    public string? UnitCode { get; set; }

    public decimal ReturnQuantity { get; set; }

    public string? ReturnFrommAreaCode { get; set; }

    public string? ReturnFromLocationCode { get; set; }

    public string? ReturnToAreaCode { get; set; }

    public string? ReturnToLocationCode { get; set; }

    public int? ReturnType { get; set; }

    public string? BatchNumber { get; set; }

    public string? CreatorCode { get; set; }

    public int Status { get; set; }

    public DateTime CreationDateTime { get; set; }

    public DateTime? Stamp { get; set; }

    public DateTime? ProcessedDateTime { get; set; }

    public int OperationType { get; set; }
}
