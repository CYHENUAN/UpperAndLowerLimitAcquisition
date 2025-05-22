using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Station
{
    public int Id { get; set; }

    public string StationNumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    /// <summary>
    /// 1:Production Station, 2:Test Station, 3: Repair Station, 4:Virtual Station
    /// </summary>
    public int? StationType { get; set; }

    /// <summary>
    /// 1:Active,0:Deactive
    /// </summary>
    public int State { get; set; }

    public int? FactoryId { get; set; }

    public int? CreatorId { get; set; }

    public virtual ICollection<AttributeDataRecord> AttributeDataRecords { get; set; } = new List<AttributeDataRecord>();

    public virtual ICollection<Cell_Station> Cell_Stations { get; set; } = new List<Cell_Station>();

    public virtual User? Creator { get; set; }

    public virtual ICollection<CurrentActivedWorkOrderInformation> CurrentActivedWorkOrderInformations { get; set; } = new List<CurrentActivedWorkOrderInformation>();

    public virtual ICollection<CurrentToolingSetupInformation> CurrentToolingSetupInformations { get; set; } = new List<CurrentToolingSetupInformation>();

    public virtual ICollection<EDocument_Relationship> EDocument_Relationships { get; set; } = new List<EDocument_Relationship>();

    public virtual User? Editor { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<FISWorkOrder> FISWorkOrders { get; set; } = new List<FISWorkOrder>();

    public virtual Factory? Factory { get; set; }

    public virtual ICollection<FailureCause_Station> FailureCause_Stations { get; set; } = new List<FailureCause_Station>();

    public virtual ICollection<FailureType_Station> FailureType_Stations { get; set; } = new List<FailureType_Station>();

    public virtual ICollection<IdCounter> IdCounters { get; set; } = new List<IdCounter>();

    public virtual ICollection<MachineCurrentToolingSetupDatum> MachineCurrentToolingSetupData { get; set; } = new List<MachineCurrentToolingSetupDatum>();

    public virtual ICollection<Machine> Machines { get; set; } = new List<Machine>();

    public virtual ICollection<MaterialPool> MaterialPools { get; set; } = new List<MaterialPool>();

    public virtual ICollection<PartFailureDataRecord> PartFailureDataRecords { get; set; } = new List<PartFailureDataRecord>();

    public virtual ICollection<PartMaterialRecordHi> PartMaterialRecordHis { get; set; } = new List<PartMaterialRecordHi>();

    public virtual ICollection<PartMaterialRecord> PartMaterialRecords { get; set; } = new List<PartMaterialRecord>();

    public virtual ICollection<PartMergeRecord> PartMergeRecords { get; set; } = new List<PartMergeRecord>();

    public virtual ICollection<PartProcessRecord> PartProcessRecordRepairStations { get; set; } = new List<PartProcessRecord>();

    public virtual ICollection<PartProcessRecord> PartProcessRecordStations { get; set; } = new List<PartProcessRecord>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual ICollection<ReplenishLocation_Station> ReplenishLocation_Stations { get; set; } = new List<ReplenishLocation_Station>();

    public virtual ICollection<SetupRecord> SetupRecords { get; set; } = new List<SetupRecord>();

    public virtual ICollection<StationParameter> StationParameters { get; set; } = new List<StationParameter>();

    public virtual ICollection<Station_Printer> Station_Printers { get; set; } = new List<Station_Printer>();

    public virtual ICollection<Station_StationGroup> Station_StationGroups { get; set; } = new List<Station_StationGroup>();

    public virtual ICollection<Stations_Skill> Stations_Skills { get; set; } = new List<Stations_Skill>();

    public virtual ICollection<WorkOrderProcessRecord> WorkOrderProcessRecords { get; set; } = new List<WorkOrderProcessRecord>();
}
