using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class FailureCause
{
    public int Id { get; set; }

    public string FailureCauseCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<FailureCause_Station> FailureCause_Stations { get; set; } = new List<FailureCause_Station>();

    public virtual ICollection<PartFailureDataRecord> PartFailureDataRecords { get; set; } = new List<PartFailureDataRecord>();

    public virtual ICollection<WorkOrderQualityRecord> WorkOrderQualityRecords { get; set; } = new List<WorkOrderQualityRecord>();
}
