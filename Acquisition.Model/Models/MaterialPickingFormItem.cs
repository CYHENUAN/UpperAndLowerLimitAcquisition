using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialPickingFormItem
{
    public int Id { get; set; }

    public int MaterialPickingFormId { get; set; }

    public int ItemNumber { get; set; }

    public int MaterialId { get; set; }

    public int UnitId { get; set; }

    public decimal RequestQuantity { get; set; }

    public int? PickingAreaId { get; set; }

    public int? RequestLocationId { get; set; }

    public decimal? ScannedQuantity { get; set; }

    public int? ScannedPackQuantity { get; set; }

    /// <summary>
    /// -1:Cancel, 0:New, 1:Picking, 2:Completed
    /// </summary>
    public int? State { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual MaterialPickingForm MaterialPickingForm { get; set; } = null!;

    public virtual ICollection<MaterialRequestFormItem_MaterialPickingFormItem> MaterialRequestFormItem_MaterialPickingFormItems { get; set; } = new List<MaterialRequestFormItem_MaterialPickingFormItem>();

    public virtual Area? PickingArea { get; set; }

    public virtual Location? RequestLocation { get; set; }

    public virtual Unit Unit { get; set; } = null!;
}
