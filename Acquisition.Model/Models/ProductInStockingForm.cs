using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ProductInStockingForm
{
    public int Id { get; set; }

    public int FormId { get; set; }

    public virtual WMSForm Form { get; set; } = null!;

    public virtual ICollection<ProductInStockingFormItem> ProductInStockingFormItems { get; set; } = new List<ProductInStockingFormItem>();
}
