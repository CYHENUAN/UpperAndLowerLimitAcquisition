using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ProductDeliveryRequestFormItem
{
    public int Id { get; set; }

    public int? ProductDeliveryRequestFormId { get; set; }

    public int? ItemNumber { get; set; }

    public int? MaterialId { get; set; }

    public decimal? RequestQuantity { get; set; }

    public decimal? ScannedQuantity { get; set; }

    public DateTime? RequiredOnBoardDateTime { get; set; }

    public DateTime? RequiredShippingDateTime { get; set; }

    public int? State { get; set; }

    public decimal? PreparedQuantity { get; set; }

    public virtual ICollection<CustomerBoxInformation> CustomerBoxInformations { get; set; } = new List<CustomerBoxInformation>();

    public virtual Material? Material { get; set; }

    public virtual ProductDeliveryRequestForm? ProductDeliveryRequestForm { get; set; }
}
