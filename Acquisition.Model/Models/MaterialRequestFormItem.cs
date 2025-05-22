using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialRequestFormItem
{
    /// <summary>
    /// -1:撤销,1:新,2配货种:,3:已配货,
    /// </summary>
    public int Id { get; set; }

    public int? MaterialRequestFormId { get; set; }

    public int? ItemNumber { get; set; }

    public int MaterialId { get; set; }

    public decimal Quantity { get; set; }

    public int DestinationLocationId { get; set; }

    public int? UnitId { get; set; }

    /// <summary>
    /// -1:Cancel, 1:New, 2:Picking, 3:Completed
    /// </summary>
    public int State { get; set; }

    public virtual Location DestinationLocation { get; set; } = null!;

    public virtual Material Material { get; set; } = null!;

    public virtual MaterialRequestForm? MaterialRequestForm { get; set; }

    public virtual ICollection<MaterialRequestFormItem_MaterialPickingFormItem> MaterialRequestFormItem_MaterialPickingFormItems { get; set; } = new List<MaterialRequestFormItem_MaterialPickingFormItem>();

    public virtual Unit? Unit { get; set; }
}
