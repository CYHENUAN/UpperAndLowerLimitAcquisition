using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialCheckInformation
{
    public long Id { get; set; }

    public long? ContainerId { get; set; }

    public DateTime? CheckDateTime { get; set; }

    public int? StocktakerId { get; set; }

    public int? MaterialCheckBillFormItemId { get; set; }

    public int? ScanLocationId { get; set; }

    public decimal? ScanQuantity { get; set; }

    public virtual Container? Container { get; set; }

    public virtual MaterialCheckBillFormItem? MaterialCheckBillFormItem { get; set; }

    public virtual Location? ScanLocation { get; set; }

    public virtual User? Stocktaker { get; set; }
}
