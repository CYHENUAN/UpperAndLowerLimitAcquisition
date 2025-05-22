using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialOtherMovementForm
{
    public int Id { get; set; }

    public int? FormId { get; set; }

    public virtual WMSForm? Form { get; set; }

    public virtual ICollection<MaterialOtherMovementFormItem> MaterialOtherMovementFormItems { get; set; } = new List<MaterialOtherMovementFormItem>();
}
