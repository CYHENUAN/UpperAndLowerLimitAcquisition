using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ProductDeliveryRequestForm
{
    public int Id { get; set; }

    public int? FormId { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public int? CustomerId { get; set; }

    public int? TargetAreaId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual WMSForm? Form { get; set; }

    public virtual ICollection<ProductDeliveryRequestFormItem> ProductDeliveryRequestFormItems { get; set; } = new List<ProductDeliveryRequestFormItem>();

    public virtual Area? TargetArea { get; set; }
}
