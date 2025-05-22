using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PartRepairQualityCheckRecord
{
    public long Id { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int SequenceNumber { get; set; }

    public long PartRepairRecordId { get; set; }

    public int CheckState { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual ICollection<PartRepairQualityCheckRecord> InversePartRepairRecord { get; set; } = new List<PartRepairQualityCheckRecord>();

    public virtual PartRepairQualityCheckRecord PartRepairRecord { get; set; } = null!;
}
