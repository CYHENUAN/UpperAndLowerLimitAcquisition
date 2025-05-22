using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialPickingForm
{
    public int Id { get; set; }

    public int FormId { get; set; }

    public long? WorkOrderId { get; set; }

    public int? PickingAreaId { get; set; }

    public int? RequestLocationId { get; set; }

    public int? TotleItem { get; set; }

    public virtual WMSForm Form { get; set; } = null!;

    public virtual ICollection<MaterialPickingFormItem> MaterialPickingFormItems { get; set; } = new List<MaterialPickingFormItem>();

    public virtual Area? PickingArea { get; set; }

    public virtual Location? RequestLocation { get; set; }

    public virtual WorkOrder? WorkOrder { get; set; }
}
