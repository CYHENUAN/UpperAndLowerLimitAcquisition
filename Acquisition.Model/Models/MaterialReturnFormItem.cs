using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialReturnFormItem
{
    public int Id { get; set; }

    public int MaterialReturnFormId { get; set; }

    public int ItemNumber { get; set; }

    public int MaterialId { get; set; }

    public int UnitId { get; set; }

    public decimal Quantity { get; set; }

    public decimal? ActualReturnQuantity { get; set; }

    public string? BatchNumber { get; set; }

    public int State { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual MaterialReturnForm MaterialReturnForm { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
