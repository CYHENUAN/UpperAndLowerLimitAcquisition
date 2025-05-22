using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ProcessStep
{
    public int Secquence { get; set; }

    public int? ProcessId { get; set; }

    public string Description { get; set; } = null!;

    public int StationGroupId { get; set; }

    public bool? IsMandatory { get; set; }

    public bool? IsNeedSetupCheck { get; set; }

    public int? MaximumTestCount { get; set; }

    public bool? IsBackflush { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int Layer { get; set; }

    public int Id { get; set; }

    public int? RepairBackSecquence { get; set; }

    public decimal? TimePerUnitInSeconds { get; set; }

    public int? State { get; set; }

    public virtual ICollection<ConcessionReleaseRecord> ConcessionReleaseRecordFromProcessSteps { get; set; } = new List<ConcessionReleaseRecord>();

    public virtual ICollection<ConcessionReleaseRecord> ConcessionReleaseRecordToProcessSteps { get; set; } = new List<ConcessionReleaseRecord>();

    public virtual ICollection<CurrentActivedWorkOrderInformation> CurrentActivedWorkOrderInformations { get; set; } = new List<CurrentActivedWorkOrderInformation>();

    public virtual ICollection<EDocument_Relationship> EDocument_Relationships { get; set; } = new List<EDocument_Relationship>();

    public virtual ICollection<FISWorkOrder> FISWorkOrders { get; set; } = new List<FISWorkOrder>();

    public virtual ICollection<PartMaterialRecordHi> PartMaterialRecordHis { get; set; } = new List<PartMaterialRecordHi>();

    public virtual ICollection<PartMaterialRecord> PartMaterialRecords { get; set; } = new List<PartMaterialRecord>();

    public virtual ICollection<PartProcessRecord> PartProcessRecords { get; set; } = new List<PartProcessRecord>();

    public virtual Process? Process { get; set; }

    public virtual ICollection<ReworkRecord> ReworkRecords { get; set; } = new List<ReworkRecord>();

    public virtual StationGroup StationGroup { get; set; } = null!;

    public virtual ICollection<WorkOrderProcessRecord> WorkOrderProcessRecords { get; set; } = new List<WorkOrderProcessRecord>();
}
