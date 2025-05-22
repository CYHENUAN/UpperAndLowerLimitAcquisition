using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class TPMMaterialRecord
{
    public int Id { get; set; }

    public int TPMWorkRecordId { get; set; }

    public int NewMaterialId { get; set; }

    public double Quantity { get; set; }

    public long? MaterialContainerId { get; set; }

    public virtual Container? MaterialContainer { get; set; }

    public virtual Material NewMaterial { get; set; } = null!;

    public virtual TPMWorkRecord TPMWorkRecord { get; set; } = null!;
}
