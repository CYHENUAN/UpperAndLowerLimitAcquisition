using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialReceivingFormItem
{
    public int Id { get; set; }

    public int MaterialReceivingFormId { get; set; }

    public int ItemNumber { get; set; }

    public int MaterialId { get; set; }

    public int SupplierId { get; set; }

    public string BatchNumber { get; set; } = null!;

    public int UnitId { get; set; }

    public decimal Quantity { get; set; }

    public decimal ReceivingQuantity { get; set; }

    public decimal ScannedQuantity { get; set; }

    public int ReceivingLocationId { get; set; }

    public int ReceiverId { get; set; }

    public DateTime ManufacturingDateTime { get; set; }

    public DateTime ExpireDateTime { get; set; }

    public int State { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual MaterialReceivingForm MaterialReceivingForm { get; set; } = null!;

    public virtual User Receiver { get; set; } = null!;

    public virtual Location ReceivingLocation { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
