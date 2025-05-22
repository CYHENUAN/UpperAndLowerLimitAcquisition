using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialCheckBillFormItem
{
    public int Id { get; set; }

    public int MaterialCheckBillFormId { get; set; }

    public int ItemNumber { get; set; }

    public int? MaterialId { get; set; }

    public int? UnitId { get; set; }

    public int? CheckLocationId { get; set; }

    public decimal? CheckQuantity { get; set; }

    public decimal? ScannedQuantity { get; set; }

    public int? State { get; set; }

    public virtual Location? CheckLocation { get; set; }

    public virtual Material? Material { get; set; }

    public virtual MaterialCheckBillForm MaterialCheckBillForm { get; set; } = null!;

    public virtual ICollection<MaterialCheckInformation> MaterialCheckInformations { get; set; } = new List<MaterialCheckInformation>();

    public virtual Unit? Unit { get; set; }
}
