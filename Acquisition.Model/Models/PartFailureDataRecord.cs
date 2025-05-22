using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PartFailureDataRecord
{
    public long Id { get; set; }

    public long PartSerialNumberId { get; set; }

    public int? SequenceNumber { get; set; }

    public int FailureTypeId { get; set; }

    public int? FailureCauseId { get; set; }

    public int Layer { get; set; }

    public string? Designator { get; set; }

    public bool? IsFalseReject { get; set; }

    public bool? IsCriticalFailure { get; set; }

    public DateTime ProductionDateTime { get; set; }

    public DateTime BookDateTime { get; set; }

    public int StationId { get; set; }

    public long? PartProcessRecordId { get; set; }

    public string? Comment { get; set; }

    public virtual FailureCause? FailureCause { get; set; }

    public virtual FailureType FailureType { get; set; } = null!;

    public virtual PartProcessRecord? PartProcessRecord { get; set; }

    public virtual ICollection<PartRepairRecord> PartRepairRecords { get; set; } = new List<PartRepairRecord>();

    public virtual PartSerialNumber PartSerialNumber { get; set; } = null!;

    public virtual Station Station { get; set; } = null!;
}
