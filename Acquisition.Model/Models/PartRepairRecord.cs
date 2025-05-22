using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PartRepairRecord
{
    public long Id { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int SequenceNumber { get; set; }

    public long PartFailureDataRecordId { get; set; }

    public int RepairState { get; set; }

    public int? RepairActionId { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual PartFailureDataRecord PartFailureDataRecord { get; set; } = null!;

    public virtual RepairAction? RepairAction { get; set; }
}
