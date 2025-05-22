using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PartSerialNumber
{
    /// <summary>
    /// 0:Deactive,1:Active
    /// </summary>
    public long Id { get; set; }

    public string MasterSerialNumber { get; set; } = null!;

    public string SerialNumber { get; set; } = null!;

    public string? Position { get; set; }

    public long? WorkOrderId { get; set; }

    public DateTime CreationDateTime { get; set; }

    /// <summary>
    /// 1:Active,0:Deactive,-1:QualityHold
    /// </summary>
    public int State { get; set; }

    /// <summary>
    /// 当没有工单和BOM的时候用，别的时候不用
    /// </summary>
    public int? MaterialId { get; set; }

    public int? NextProcessStepSequence { get; set; }

    public virtual ICollection<CarrierBindRecord> CarrierBindRecords { get; set; } = new List<CarrierBindRecord>();

    public virtual ICollection<Carrier> Carriers { get; set; } = new List<Carrier>();

    public virtual ICollection<ConcessionReleaseRecord_PartSerialNumber> ConcessionReleaseRecord_PartSerialNumbers { get; set; } = new List<ConcessionReleaseRecord_PartSerialNumber>();

    public virtual ICollection<IPQCForm> IPQCForms { get; set; } = new List<IPQCForm>();

    public virtual ICollection<LockUnlockPartSNRecord_PartSerialNumber> LockUnlockPartSNRecord_PartSerialNumbers { get; set; } = new List<LockUnlockPartSNRecord_PartSerialNumber>();

    public virtual ICollection<MSATestRecord> MSATestRecords { get; set; } = new List<MSATestRecord>();

    public virtual Material? Material { get; set; }

    public virtual ICollection<PackingInformation> PackingInformations { get; set; } = new List<PackingInformation>();

    public virtual ICollection<PartFailureDataRecord> PartFailureDataRecords { get; set; } = new List<PartFailureDataRecord>();

    public virtual ICollection<PartMaterialRecordHi> PartMaterialRecordHis { get; set; } = new List<PartMaterialRecordHi>();

    public virtual ICollection<PartMaterialRecord> PartMaterialRecords { get; set; } = new List<PartMaterialRecord>();

    public virtual ICollection<PartMergeRecord> PartMergeRecordMasterPartSerialNumbers { get; set; } = new List<PartMergeRecord>();

    public virtual ICollection<PartMergeRecord> PartMergeRecordSlavePartSerialNumbers { get; set; } = new List<PartMergeRecord>();

    public virtual ICollection<PartProcessRecord> PartProcessRecords { get; set; } = new List<PartProcessRecord>();

    public virtual ICollection<ReworkRecord_PartSerialNumber> ReworkRecord_PartSerialNumbers { get; set; } = new List<ReworkRecord_PartSerialNumber>();

    public virtual ICollection<SerialNumberSwitchRecord> SerialNumberSwitchRecords { get; set; } = new List<SerialNumberSwitchRecord>();

    public virtual WorkOrder? WorkOrder { get; set; }
}
