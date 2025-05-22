using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialRequestFormItem_MaterialPickingFormItem
{
    public int Id { get; set; }

    public int? MaterialRequestFormItemId { get; set; }

    public int? MaterialPickingFormItemId { get; set; }

    public virtual MaterialPickingFormItem? MaterialPickingFormItem { get; set; }

    public virtual MaterialRequestFormItem? MaterialRequestFormItem { get; set; }
}
