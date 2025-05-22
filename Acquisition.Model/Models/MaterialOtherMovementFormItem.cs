using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialOtherMovementFormItem
{
    public int Id { get; set; }

    public int? MaterialOtherMovementFormId { get; set; }

    public int? ItemNumber { get; set; }

    public int? MaterialId { get; set; }

    public decimal? RequestQuantity { get; set; }

    public decimal? ScannedQuantity { get; set; }

    public decimal? ReceivingScannedQuantity { get; set; }

    public int? UnitId { get; set; }

    public int? SourceAreaId { get; set; }

    public int? TargetAreaId { get; set; }

    public int? SupplierAreaId { get; set; }

    public int? State { get; set; }

    public virtual ICollection<CustomerBoxInformation> CustomerBoxInformations { get; set; } = new List<CustomerBoxInformation>();

    public virtual Material? Material { get; set; }

    public virtual MaterialOtherMovementForm? MaterialOtherMovementForm { get; set; }

    public virtual Area? SourceArea { get; set; }

    public virtual Area? SupplierArea { get; set; }

    public virtual Area? TargetArea { get; set; }

    public virtual Unit? Unit { get; set; }
}
