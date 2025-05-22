using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PartProcessRecord
{
    public long Id { get; set; }

    public int? ProcessStepId { get; set; }

    public long PartSerialNumberId { get; set; }

    /// <summary>
    /// -1:JustStartProduction, 0:Pass,1:Fail,2:Scrap
    /// </summary>
    public int ProcessState { get; set; }

    public int StationId { get; set; }

    public int? Layer { get; set; }

    public DateTime ProductionDateTime { get; set; }

    public DateTime? ProductionCompleteDateTime { get; set; }

    public DateTime? BookDateTime { get; set; }

    public double? CycleTime { get; set; }

    public int? RepairStationId { get; set; }

    public int? OperatorId { get; set; }

    public decimal? UploadQuantity { get; set; }

    public DateTime? ArchiveDateTime { get; set; }

    public virtual ICollection<FailureSlip> FailureSlips { get; set; } = new List<FailureSlip>();

    public virtual User? Operator { get; set; }

    public virtual ICollection<PartFailureDataRecord> PartFailureDataRecords { get; set; } = new List<PartFailureDataRecord>();

    public virtual ICollection<PartMeasurementDataRecord> PartMeasurementDataRecords { get; set; } = new List<PartMeasurementDataRecord>();

    public virtual ICollection<PartProcessOperationStepRecord> PartProcessOperationStepRecords { get; set; } = new List<PartProcessOperationStepRecord>();

    public virtual PartSerialNumber PartSerialNumber { get; set; } = null!;

    public virtual ProcessStep? ProcessStep { get; set; }

    public virtual Station? RepairStation { get; set; }

    public virtual Station Station { get; set; } = null!;
}
