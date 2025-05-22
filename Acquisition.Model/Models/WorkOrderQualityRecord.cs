using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class WorkOrderQualityRecord
{
    public long Id { get; set; }

    public long? WorkOrderProcessRecordId { get; set; }

    public decimal? FailQuantity { get; set; }

    public int? FailureTypeId { get; set; }

    public int? FailureCauseId { get; set; }

    public string? Comment { get; set; }

    public DateTime? RecordDateTime { get; set; }

    public int? OperatorId { get; set; }

    public virtual FailureCause? FailureCause { get; set; }

    public virtual FailureType? FailureType { get; set; }

    public virtual User? Operator { get; set; }

    public virtual WorkOrderProcessRecord? WorkOrderProcessRecord { get; set; }
}
