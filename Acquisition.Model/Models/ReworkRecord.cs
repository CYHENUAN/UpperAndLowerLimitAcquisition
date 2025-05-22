using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ReworkRecord
{
    public int Id { get; set; }

    public string CreationDateTime { get; set; } = null!;

    public int CreatorId { get; set; }

    public long WorkOrderId { get; set; }

    public int FromProcessStepId { get; set; }

    public string? Comment { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual ProcessStep FromProcessStep { get; set; } = null!;

    public virtual ICollection<ReworkRecord_PartSerialNumber> ReworkRecord_PartSerialNumbers { get; set; } = new List<ReworkRecord_PartSerialNumber>();

    public virtual WorkOrder WorkOrder { get; set; } = null!;
}
