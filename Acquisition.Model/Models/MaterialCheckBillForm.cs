using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialCheckBillForm
{
    public int Id { get; set; }

    public int FormId { get; set; }

    public int CheckAreaId { get; set; }

    public virtual Area CheckArea { get; set; } = null!;

    public virtual WMSForm Form { get; set; } = null!;

    public virtual ICollection<MaterialCheckBillFormItem> MaterialCheckBillFormItems { get; set; } = new List<MaterialCheckBillFormItem>();
}
