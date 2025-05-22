using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class FailureType
{
    public int Id { get; set; }

    public string FailureCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    /// <summary>
    /// 1:工废，2：料废
    /// </summary>
    public int? CategoryId { get; set; }

    public virtual ICollection<FailureType_Station> FailureType_Stations { get; set; } = new List<FailureType_Station>();

    public virtual ICollection<PartFailureDataRecord> PartFailureDataRecords { get; set; } = new List<PartFailureDataRecord>();

    public virtual ICollection<WorkOrderQualityRecord> WorkOrderQualityRecords { get; set; } = new List<WorkOrderQualityRecord>();
}
