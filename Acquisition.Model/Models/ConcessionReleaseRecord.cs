using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ConcessionReleaseRecord
{
    public int Id { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int CreatorId { get; set; }

    public long WorkOrderId { get; set; }

    public int FromProcessStepId { get; set; }

    public int ToProcessStepId { get; set; }

    public string? Comment { get; set; }

    public virtual ICollection<ConcessionReleaseRecord_PartSerialNumber> ConcessionReleaseRecord_PartSerialNumbers { get; set; } = new List<ConcessionReleaseRecord_PartSerialNumber>();

    public virtual User Creator { get; set; } = null!;

    public virtual ProcessStep FromProcessStep { get; set; } = null!;

    public virtual ProcessStep ToProcessStep { get; set; } = null!;

    public virtual WorkOrder WorkOrder { get; set; } = null!;
}
