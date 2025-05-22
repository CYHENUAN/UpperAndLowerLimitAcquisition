using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialReturnForm
{
    public int Id { get; set; }

    public int FormId { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public int SupplierId { get; set; }

    public virtual WMSForm Form { get; set; } = null!;

    public virtual ICollection<MaterialReturnFormItem> MaterialReturnFormItems { get; set; } = new List<MaterialReturnFormItem>();

    public virtual Supplier Supplier { get; set; } = null!;
}
