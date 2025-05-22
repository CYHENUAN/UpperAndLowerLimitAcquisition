using System;
using System.Collections.Generic;
using Acquisition.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Acquisition.Model.MyDbContext;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AGVDataConfig> AGVDataConfigs { get; set; }

    public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AttributeDataRecord> AttributeDataRecords { get; set; }

    public virtual DbSet<AttributeType> AttributeTypes { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<BOMHead> BOMHeads { get; set; }

    public virtual DbSet<BOMItem> BOMItems { get; set; }

    public virtual DbSet<Carrier> Carriers { get; set; }

    public virtual DbSet<CarrierBindRecord> CarrierBindRecords { get; set; }

    public virtual DbSet<Cell> Cells { get; set; }

    public virtual DbSet<Cell_Station> Cell_Stations { get; set; }

    public virtual DbSet<Certification> Certifications { get; set; }

    public virtual DbSet<Certification_User> Certification_Users { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyParameter> CompanyParameters { get; set; }

    public virtual DbSet<ConcessionReleaseRecord> ConcessionReleaseRecords { get; set; }

    public virtual DbSet<ConcessionReleaseRecord_PartSerialNumber> ConcessionReleaseRecord_PartSerialNumbers { get; set; }

    public virtual DbSet<Container> Containers { get; set; }

    public virtual DbSet<ContainerGenerateRecord> ContainerGenerateRecords { get; set; }

    public virtual DbSet<ContainerLabelPrintRecord> ContainerLabelPrintRecords { get; set; }

    public virtual DbSet<Core_Area> Core_Areas { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<CurrentActivedWorkOrderInformation> CurrentActivedWorkOrderInformations { get; set; }

    public virtual DbSet<CurrentToolingSetupInformation> CurrentToolingSetupInformations { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerBoxInformation> CustomerBoxInformations { get; set; }

    public virtual DbSet<EDocument> EDocuments { get; set; }

    public virtual DbSet<EDocumentType> EDocumentTypes { get; set; }

    public virtual DbSet<EDocument_Relationship> EDocument_Relationships { get; set; }

    public virtual DbSet<ERPMaterialHi> ERPMaterialHis { get; set; }

    public virtual DbSet<ERPWorkOrderHi> ERPWorkOrderHis { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventActionRecord> EventActionRecords { get; set; }

    public virtual DbSet<EventCategory> EventCategories { get; set; }

    public virtual DbSet<EventEscalationProcess> EventEscalationProcesses { get; set; }

    public virtual DbSet<EventEscalationProcessStep> EventEscalationProcessSteps { get; set; }

    public virtual DbSet<EventEvaluationRecord> EventEvaluationRecords { get; set; }

    public virtual DbSet<EventKnowledgeLibrary> EventKnowledgeLibraries { get; set; }

    public virtual DbSet<EventProblemTag> EventProblemTags { get; set; }

    public virtual DbSet<EventProcessChangeDetail> EventProcessChangeDetails { get; set; }

    public virtual DbSet<EventProcessChangeLog> EventProcessChangeLogs { get; set; }

    public virtual DbSet<EventSubscription> EventSubscriptions { get; set; }

    public virtual DbSet<EventSymptom> EventSymptoms { get; set; }

    public virtual DbSet<Event_KnowledgeLib> Event_KnowledgeLibs { get; set; }

    public virtual DbSet<FISWorkOrder> FISWorkOrders { get; set; }

    public virtual DbSet<Factory> Factories { get; set; }

    public virtual DbSet<FailureCause> FailureCauses { get; set; }

    public virtual DbSet<FailureCause_Station> FailureCause_Stations { get; set; }

    public virtual DbSet<FailureSlip> FailureSlips { get; set; }

    public virtual DbSet<FailureType> FailureTypes { get; set; }

    public virtual DbSet<FailureType_Station> FailureType_Stations { get; set; }

    public virtual DbSet<FormType> FormTypes { get; set; }

    public virtual DbSet<IPQCForm> IPQCForms { get; set; }

    public virtual DbSet<IPQCRecord> IPQCRecords { get; set; }

    public virtual DbSet<IQCForm> IQCForms { get; set; }

    public virtual DbSet<IQCRecord> IQCRecords { get; set; }

    public virtual DbSet<IdCounter> IdCounters { get; set; }

    public virtual DbSet<IdLayout> IdLayouts { get; set; }

    public virtual DbSet<IdModel> IdModels { get; set; }

    public virtual DbSet<IdModelAssignment> IdModelAssignments { get; set; }

    public virtual DbSet<JPH> JPHs { get; set; }

    public virtual DbSet<KnowledgeLib_ProblemTag> KnowledgeLib_ProblemTags { get; set; }

    public virtual DbSet<Line> Lines { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LockUnlockPartSNRecord> LockUnlockPartSNRecords { get; set; }

    public virtual DbSet<LockUnlockPartSNRecord_PartSerialNumber> LockUnlockPartSNRecord_PartSerialNumbers { get; set; }

    public virtual DbSet<MESParameterReference> MESParameterReferences { get; set; }

    public virtual DbSet<MSATest> MSATests { get; set; }

    public virtual DbSet<MSATestRecord> MSATestRecords { get; set; }

    public virtual DbSet<MSL> MSLs { get; set; }

    public virtual DbSet<Machine> Machines { get; set; }

    public virtual DbSet<MachineConfiguration> MachineConfigurations { get; set; }

    public virtual DbSet<MachineCurrentToolingSetupDatum> MachineCurrentToolingSetupData { get; set; }

    public virtual DbSet<MachineErrorInformation> MachineErrorInformations { get; set; }

    public virtual DbSet<MachineMessageLog> MachineMessageLogs { get; set; }

    public virtual DbSet<MachineRunningInformation> MachineRunningInformations { get; set; }

    public virtual DbSet<MaintenanceItem> MaintenanceItems { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MaterialCheckBillForm> MaterialCheckBillForms { get; set; }

    public virtual DbSet<MaterialCheckBillFormItem> MaterialCheckBillFormItems { get; set; }

    public virtual DbSet<MaterialCheckInformation> MaterialCheckInformations { get; set; }

    public virtual DbSet<MaterialGroup> MaterialGroups { get; set; }

    public virtual DbSet<MaterialOtherMovementForm> MaterialOtherMovementForms { get; set; }

    public virtual DbSet<MaterialOtherMovementFormItem> MaterialOtherMovementFormItems { get; set; }

    public virtual DbSet<MaterialPickingForm> MaterialPickingForms { get; set; }

    public virtual DbSet<MaterialPickingFormItem> MaterialPickingFormItems { get; set; }

    public virtual DbSet<MaterialPool> MaterialPools { get; set; }

    public virtual DbSet<MaterialQueue> MaterialQueues { get; set; }

    public virtual DbSet<MaterialReceivingForm> MaterialReceivingForms { get; set; }

    public virtual DbSet<MaterialReceivingFormItem> MaterialReceivingFormItems { get; set; }

    public virtual DbSet<MaterialRequestForm> MaterialRequestForms { get; set; }

    public virtual DbSet<MaterialRequestFormItem> MaterialRequestFormItems { get; set; }

    public virtual DbSet<MaterialRequestFormItem_MaterialPickingFormItem> MaterialRequestFormItem_MaterialPickingFormItems { get; set; }

    public virtual DbSet<MaterialReturnForm> MaterialReturnForms { get; set; }

    public virtual DbSet<MaterialReturnFormItem> MaterialReturnFormItems { get; set; }

    public virtual DbSet<Material_Process> Material_Processes { get; set; }

    public virtual DbSet<Material_SupplierMaterialBarcode> Material_SupplierMaterialBarcodes { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MessageType> MessageTypes { get; set; }

    public virtual DbSet<MovementRecord> MovementRecords { get; set; }

    public virtual DbSet<OperationStep> OperationSteps { get; set; }

    public virtual DbSet<OrderConfirmation> OrderConfirmations { get; set; }

    public virtual DbSet<PMCStationDataX> PMCStationDataXes { get; set; }

    public virtual DbSet<PackingInformation> PackingInformations { get; set; }

    public virtual DbSet<PackingInformationHi> PackingInformationHis { get; set; }

    public virtual DbSet<PartConfiguration> PartConfigurations { get; set; }

    public virtual DbSet<PartFailureDataRecord> PartFailureDataRecords { get; set; }

    public virtual DbSet<PartLabelPrintRecord> PartLabelPrintRecords { get; set; }

    public virtual DbSet<PartMaterialRecord> PartMaterialRecords { get; set; }

    public virtual DbSet<PartMaterialRecordHi> PartMaterialRecordHis { get; set; }

    public virtual DbSet<PartMeasurementDataRecord> PartMeasurementDataRecords { get; set; }

    public virtual DbSet<PartMergeRecord> PartMergeRecords { get; set; }

    public virtual DbSet<PartProcessOperationStepRecord> PartProcessOperationStepRecords { get; set; }

    public virtual DbSet<PartProcessRecord> PartProcessRecords { get; set; }

    public virtual DbSet<PartRepairQualityCheckRecord> PartRepairQualityCheckRecords { get; set; }

    public virtual DbSet<PartRepairRecord> PartRepairRecords { get; set; }

    public virtual DbSet<PartSerialNumber> PartSerialNumbers { get; set; }

    public virtual DbSet<Platform> Platforms { get; set; }

    public virtual DbSet<Process> Processes { get; set; }

    public virtual DbSet<ProcessStep> ProcessSteps { get; set; }

    public virtual DbSet<ProcurementType> ProcurementTypes { get; set; }

    public virtual DbSet<ProductDeliveryRequestForm> ProductDeliveryRequestForms { get; set; }

    public virtual DbSet<ProductDeliveryRequestFormItem> ProductDeliveryRequestFormItems { get; set; }

    public virtual DbSet<ProductInStockingForm> ProductInStockingForms { get; set; }

    public virtual DbSet<ProductInStockingFormItem> ProductInStockingFormItems { get; set; }

    public virtual DbSet<ProductModel> ProductModels { get; set; }

    public virtual DbSet<ProductionPlan> ProductionPlans { get; set; }

    public virtual DbSet<ProductionPlanRecord> ProductionPlanRecords { get; set; }

    public virtual DbSet<QCStationDataX> QCStationDataXes { get; set; }

    public virtual DbSet<QualityHoldForm> QualityHoldForms { get; set; }

    public virtual DbSet<QualityHoldFormItem> QualityHoldFormItems { get; set; }

    public virtual DbSet<QualityUnHoldForm> QualityUnHoldForms { get; set; }

    public virtual DbSet<QualityUnHoldFormItem> QualityUnHoldFormItems { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<RecipeItem> RecipeItems { get; set; }

    public virtual DbSet<RecipeItemRevisionRecord> RecipeItemRevisionRecords { get; set; }

    public virtual DbSet<RepairAction> RepairActions { get; set; }

    public virtual DbSet<ReplenishLocation_Station> ReplenishLocation_Stations { get; set; }

    public virtual DbSet<ReworkRecord> ReworkRecords { get; set; }

    public virtual DbSet<ReworkRecord_PartSerialNumber> ReworkRecord_PartSerialNumbers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleAuth> RoleAuths { get; set; }

    public virtual DbSet<Role_Area> Role_Areas { get; set; }

    public virtual DbSet<Roles_User> Roles_Users { get; set; }

    public virtual DbSet<SMTChangeOverTable> SMTChangeOverTables { get; set; }

    public virtual DbSet<SMTChangeOverTableSetup> SMTChangeOverTableSetups { get; set; }

    public virtual DbSet<SMTLine> SMTLines { get; set; }

    public virtual DbSet<SMTLine_SMTMachine> SMTLine_SMTMachines { get; set; }

    public virtual DbSet<SMTMachine> SMTMachines { get; set; }

    public virtual DbSet<SMTMachineArea> SMTMachineAreas { get; set; }

    public virtual DbSet<SMTOnlineProgram> SMTOnlinePrograms { get; set; }

    public virtual DbSet<SMTOnlineSetup> SMTOnlineSetups { get; set; }

    public virtual DbSet<SMTProgram> SMTPrograms { get; set; }

    public virtual DbSet<SMTProgramDetail> SMTProgramDetails { get; set; }

    public virtual DbSet<SMTSetup> SMTSetups { get; set; }

    public virtual DbSet<SMTSetupListItem> SMTSetupListItems { get; set; }

    public virtual DbSet<SNCounter> SNCounters { get; set; }

    public virtual DbSet<SerialNumberRegex> SerialNumberRegexes { get; set; }

    public virtual DbSet<SerialNumberSwitchRecord> SerialNumberSwitchRecords { get; set; }

    public virtual DbSet<SetupRecord> SetupRecords { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<SolderPaste> SolderPastes { get; set; }

    public virtual DbSet<SolderPasteEventHistory> SolderPasteEventHistories { get; set; }

    public virtual DbSet<SolderPrintingMachineRecipe> SolderPrintingMachineRecipes { get; set; }

    public virtual DbSet<SolderPrintingSetting> SolderPrintingSettings { get; set; }

    public virtual DbSet<Squeege> Squeeges { get; set; }

    public virtual DbSet<SqueegeEventHistory> SqueegeEventHistories { get; set; }

    public virtual DbSet<SqueegeType> SqueegeTypes { get; set; }

    public virtual DbSet<Station> Stations { get; set; }

    public virtual DbSet<StationCurrentStatus> StationCurrentStatuses { get; set; }

    public virtual DbSet<StationFailure> StationFailures { get; set; }

    public virtual DbSet<StationGroup> StationGroups { get; set; }

    public virtual DbSet<StationParameter> StationParameters { get; set; }

    public virtual DbSet<StationStatusHi> StationStatusHis { get; set; }

    public virtual DbSet<Station_Printer> Station_Printers { get; set; }

    public virtual DbSet<Station_StationGroup> Station_StationGroups { get; set; }

    public virtual DbSet<Stations_Skill> Stations_Skills { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TPMMaterialRecord> TPMMaterialRecords { get; set; }

    public virtual DbSet<TPMReminder> TPMReminders { get; set; }

    public virtual DbSet<TPMWorkOrder> TPMWorkOrders { get; set; }

    public virtual DbSet<TPMWorkOrderItem> TPMWorkOrderItems { get; set; }

    public virtual DbSet<TPMWorkOrderItemTransferRecord> TPMWorkOrderItemTransferRecords { get; set; }

    public virtual DbSet<TPMWorkOrder_TPMWorkPlan> TPMWorkOrder_TPMWorkPlans { get; set; }

    public virtual DbSet<TPMWorkPlan> TPMWorkPlans { get; set; }

    public virtual DbSet<TPMWorkPlanItem> TPMWorkPlanItems { get; set; }

    public virtual DbSet<TPMWorkRecord> TPMWorkRecords { get; set; }

    public virtual DbSet<Tooling> Toolings { get; set; }

    public virtual DbSet<ToolingLife> ToolingLives { get; set; }

    public virtual DbSet<ToolingLifeCheckRule> ToolingLifeCheckRules { get; set; }

    public virtual DbSet<ToolingType> ToolingTypes { get; set; }

    public virtual DbSet<ToolingType_ToolingLifeCheckRule> ToolingType_ToolingLifeCheckRules { get; set; }

    public virtual DbSet<UPH> UPHs { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserFingerprint> UserFingerprints { get; set; }

    public virtual DbSet<WMSForm> WMSForms { get; set; }

    public virtual DbSet<WMSWorkOrder> WMSWorkOrders { get; set; }

    public virtual DbSet<WMS_ManufacturingMaterialReturnRecord> WMS_ManufacturingMaterialReturnRecords { get; set; }

    public virtual DbSet<WMS_WorkOrderBackflushRecord> WMS_WorkOrderBackflushRecords { get; set; }

    public virtual DbSet<WorkOrder> WorkOrders { get; set; }

    public virtual DbSet<WorkOrderMaterialRecord> WorkOrderMaterialRecords { get; set; }

    public virtual DbSet<WorkOrderProcessRecord> WorkOrderProcessRecords { get; set; }

    public virtual DbSet<WorkOrderQualityRecord> WorkOrderQualityRecords { get; set; }

    public virtual DbSet<WorkOrder_Cell> WorkOrder_Cells { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=MESDB_Acqu;User ID=sa;Password=sql;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AGVDataConfig>(entity =>
        {
            entity.ToTable("AGVDataConfig");

            entity.Property(e => e.AGVSite)
                .HasMaxLength(50)
                .HasComment("AGV的工位点位");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.MaterialName)
                .HasMaxLength(50)
                .HasComment("物料名称");
            entity.Property(e => e.MaterialNumber)
                .HasMaxLength(100)
                .HasComment("物料编号");
            entity.Property(e => e.StationNumber)
                .HasMaxLength(50)
                .HasComment("MES工位号");
        });

        modelBuilder.Entity<AggregatedCounter>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PK_HangFire_CounterAggregated");

            entity.ToTable("AggregatedCounter", "HangFire");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.ToTable("Area", "core");

            entity.Property(e => e.AreaNumber).HasMaxLength(255);
            entity.Property(e => e.AreaType).HasComment("0：virtual ，1：WareHouse，2：Department");
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Creator).WithMany(p => p.AreaCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Area_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.AreaEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Area_User1");

            entity.HasOne(d => d.Factory).WithMany(p => p.Areas)
                .HasForeignKey(d => d.FactoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Area_Factory");
        });

        modelBuilder.Entity<AttributeDataRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AttributeData");

            entity.ToTable("AttributeDataRecord", "trace", tb => tb.HasComment("属性绑定数据"));

            entity.Property(e => e.AssignMethod).HasComment("1:API,2:ManualInput");
            entity.Property(e => e.AttributeValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.EntityId).HasComment("1");
            entity.Property(e => e.EntityType).HasComment("被附加属性的对象实体的类型名,1:PartSerialNumber,2:WorkOrder,3:Container");
            entity.Property(e => e.EntityUniqueCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.AssignedStationNumber).WithMany(p => p.AttributeDataRecords)
                .HasForeignKey(d => d.AssignedStationNumberId)
                .HasConstraintName("FK_AttributeDataRecord_Station");

            entity.HasOne(d => d.AttributeType).WithMany(p => p.AttributeDataRecords)
                .HasForeignKey(d => d.AttributeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttributeData_AttributeType");

            entity.HasOne(d => d.Creator).WithMany(p => p.AttributeDataRecords)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttributeData_User");
        });

        modelBuilder.Entity<AttributeType>(entity =>
        {
            entity.ToTable("AttributeType", "core", tb => tb.HasComment("附加属性类型"));

            entity.Property(e => e.AttributeCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AttributeEntityType).HasComment("被附加属性的对象实体的类型名,1:PartSerialNumber,2:WorkOrder,3:Container");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.AttributeTypeCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttributeType_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.AttributeTypeEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_AttributeType_User1");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.LogID).HasName("PK_Adm_Logs");

            entity.ToTable("AuditLog", "core");

            entity.Property(e => e.Account)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BrowerInfo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClientIpAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClientName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Exception)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ExectionTime).HasColumnType("datetime");
            entity.Property(e => e.MethodName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Parameters)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ServiceName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Platfrom).WithMany(p => p.AuditLogs)
                .HasForeignKey(d => d.PlatfromID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Adm_AuditLogs_Adm_Platfrom");
        });

        modelBuilder.Entity<BOMHead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BOM");

            entity.ToTable("BOMHead", "core");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.ERPBOMVersion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.ValidBegin).HasColumnType("datetime");
            entity.Property(e => e.ValidEnd).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.BOMHeadCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_BOMHead_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.BOMHeadEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_BOMHead_User1");

            entity.HasOne(d => d.Factory).WithMany(p => p.BOMHeads)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_BOMHead_Factory");

            entity.HasOne(d => d.Material).WithMany(p => p.BOMHeads)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOMHead_Material");
        });

        modelBuilder.Entity<BOMItem>(entity =>
        {
            entity.ToTable("BOMItem", "core");

            entity.Property(e => e.Designator)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsUnique)
                .HasDefaultValue(true)
                .HasComment("0=Batch;1=Unique");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.BOMHead).WithMany(p => p.BOMItems)
                .HasForeignKey(d => d.BOMHeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOMItem_BOMHead");

            entity.HasOne(d => d.Material).WithMany(p => p.BOMItems)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOMItem_Materiel");

            entity.HasOne(d => d.StationGroup).WithMany(p => p.BOMItems)
                .HasForeignKey(d => d.StationGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOMItem_StationGroup");
        });

        modelBuilder.Entity<Carrier>(entity =>
        {
            entity.ToTable("Carrier", "core");

            entity.Property(e => e.CarrierNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.CarrierCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Carrier_User");

            entity.HasOne(d => d.CurrentPart).WithMany(p => p.Carriers)
                .HasForeignKey(d => d.CurrentPartId)
                .HasConstraintName("FK_Carrier_PartSerialNumber");

            entity.HasOne(d => d.Editor).WithMany(p => p.CarrierEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Carrier_User1");
        });

        modelBuilder.Entity<CarrierBindRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CarrierB__3214EC07AECDADBC");

            entity.ToTable("CarrierBindRecord", "trace");

            entity.Property(e => e.OperationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Carrier).WithMany(p => p.CarrierBindRecords)
                .HasForeignKey(d => d.CarrierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CarrierBindRecord_Carrier");

            entity.HasOne(d => d.Operator).WithMany(p => p.CarrierBindRecords)
                .HasForeignKey(d => d.OperatorId)
                .HasConstraintName("FK_CarrierBindRecord_User");

            entity.HasOne(d => d.PartSerialNumber).WithMany(p => p.CarrierBindRecords)
                .HasForeignKey(d => d.PartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CarrierBindRecord_PartSerialNumber");
        });

        modelBuilder.Entity<Cell>(entity =>
        {
            entity.ToTable("Cell", "core");

            entity.Property(e => e.CellNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.CellCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Cell_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.CellEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Cell_User1");

            entity.HasOne(d => d.Factory).WithMany(p => p.Cells)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_Cell_Factory");
        });

        modelBuilder.Entity<Cell_Station>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CellRelationTab");

            entity.ToTable("Cell_Station", "core");

            entity.Property(e => e.EditDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Cell).WithMany(p => p.Cell_Stations)
                .HasForeignKey(d => d.CellId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cell_Station_Cell");

            entity.HasOne(d => d.Editor).WithMany(p => p.Cell_Stations)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Cell_Station_User");

            entity.HasOne(d => d.Station).WithMany(p => p.Cell_Stations)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cell_Station_Station");
        });

        modelBuilder.Entity<Certification>(entity =>
        {
            entity.ToTable("Certification", "core");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExpireDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Skill).WithMany(p => p.Certifications)
                .HasForeignKey(d => d.SkillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Certification_Skill");
        });

        modelBuilder.Entity<Certification_User>(entity =>
        {
            entity.ToTable("Certification_Users", "core");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.Certification_UserCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Certification_Users_User1");

            entity.HasOne(d => d.StationGroup).WithMany(p => p.Certification_Users)
                .HasForeignKey(d => d.StationGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Certification_Users_StationGroup");

            entity.HasOne(d => d.User).WithMany(p => p.Certification_UserUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Certification_Users_User");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company", "core");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.DUNS)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PostCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Telphone)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.CompanyCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Company_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.CompanyEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Company_User1");
        });

        modelBuilder.Entity<CompanyParameter>(entity =>
        {
            entity.ToTable("CompanyParameter", "core");

            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.ParameterValue)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyParameters)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyParameter_Company");

            entity.HasOne(d => d.Editor).WithMany(p => p.CompanyParameters)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_CompanyParameter_User");

            entity.HasOne(d => d.MESParameterReference).WithMany(p => p.CompanyParameters)
                .HasForeignKey(d => d.MESParameterReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompanyParameter_MESParameterReference");
        });

        modelBuilder.Entity<ConcessionReleaseRecord>(entity =>
        {
            entity.ToTable("ConcessionReleaseRecord", "qms");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.ConcessionReleaseRecords)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConcessionReleaseRecord_User");

            entity.HasOne(d => d.FromProcessStep).WithMany(p => p.ConcessionReleaseRecordFromProcessSteps)
                .HasForeignKey(d => d.FromProcessStepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConcessionReleaseRecord.FromProcessStepId_ProcessStep");

            entity.HasOne(d => d.ToProcessStep).WithMany(p => p.ConcessionReleaseRecordToProcessSteps)
                .HasForeignKey(d => d.ToProcessStepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConcessionReleaseRecord.ToProcessStepId_ProcessStep");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.ConcessionReleaseRecords)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConcessionReleaseRecord_WorkOrder");
        });

        modelBuilder.Entity<ConcessionReleaseRecord_PartSerialNumber>(entity =>
        {
            entity.ToTable("ConcessionReleaseRecord_PartSerialNumber", "qms");

            entity.HasOne(d => d.ConcessionReleaseRecord).WithMany(p => p.ConcessionReleaseRecord_PartSerialNumbers)
                .HasForeignKey(d => d.ConcessionReleaseRecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConcessionReleaseRecord_PartSerialNumber_ConcessionReleaseRecord");

            entity.HasOne(d => d.PartSerialNumber).WithMany(p => p.ConcessionReleaseRecord_PartSerialNumbers)
                .HasForeignKey(d => d.PartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConcessionReleaseRecord_PartSerialNumber_PartSerialNumber");
        });

        modelBuilder.Entity<Container>(entity =>
        {
            entity.ToTable("Container", "core");

            entity.Property(e => e.Id).HasComment("0:Deactive,1:Active");
            entity.Property(e => e.BatchNumber).HasMaxLength(255);
            entity.Property(e => e.ContainerNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.MSDLifeReminingTimeInMinute).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ManufacturingDateTime).HasColumnType("datetime");
            entity.Property(e => e.PackingCompleteDateTime).HasColumnType("datetime");
            entity.Property(e => e.PackingStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.State).HasComment("0 : Deactive, 1:Active, -1:QualityHold");
            entity.Property(e => e.TotalQuantity).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Creator).WithMany(p => p.ContainerCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Container_User");

            entity.HasOne(d => d.CurrentLocation).WithMany(p => p.Containers)
                .HasForeignKey(d => d.CurrentLocationId)
                .HasConstraintName("FK_Container_Location");

            entity.HasOne(d => d.Material).WithMany(p => p.Containers)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_Container_Materiel");

            entity.HasOne(d => d.PackingUser).WithMany(p => p.ContainerPackingUsers)
                .HasForeignKey(d => d.PackingUserId)
                .HasConstraintName("FK_Container_User1");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Containers)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Container_Supplier");
        });

        modelBuilder.Entity<ContainerGenerateRecord>(entity =>
        {
            entity.ToTable("ContainerGenerateRecord", "wms");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Container).WithMany(p => p.ContainerGenerateRecords)
                .HasForeignKey(d => d.ContainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContainerGenerateRecord_Container");

            entity.HasOne(d => d.CreationLocation).WithMany(p => p.ContainerGenerateRecords)
                .HasForeignKey(d => d.CreationLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContainerGenerateRecord_Location");

            entity.HasOne(d => d.Creator).WithMany(p => p.ContainerGenerateRecords)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContainerGenerateRecord_User");

            entity.HasOne(d => d.GenerateTypeNavigation).WithMany(p => p.ContainerGenerateRecords)
                .HasForeignKey(d => d.GenerateType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContainerGenerateRecord_FormType");
        });

        modelBuilder.Entity<ContainerLabelPrintRecord>(entity =>
        {
            entity.ToTable("ContainerLabelPrintRecord", "ProjAppleTrace");

            entity.Property(e => e.BatchNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContainerNumber)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MPQ).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MaterialName).HasMaxLength(100);
            entity.Property(e => e.MaterialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaterialSpecification).HasMaxLength(100);
            entity.Property(e => e.OperatorAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OperatorName).HasMaxLength(50);
            entity.Property(e => e.POItemNnumber)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PrintDateTime).HasColumnType("datetime");
            entity.Property(e => e.PrintType).HasComment("1:NewPrint,2:RePrint");
            entity.Property(e => e.PurchaseOrderCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StationNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName).HasMaxLength(50);
            entity.Property(e => e.UnitName).HasMaxLength(10);
        });

        modelBuilder.Entity<Core_Area>(entity =>
        {
            entity.ToTable("Core_Area", "xapi");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ProcessedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Stamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Counter", "HangFire");

            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.Key).HasMaxLength(100);
        });

        modelBuilder.Entity<CurrentActivedWorkOrderInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CurrentActiveWorkOrderInformation");

            entity.ToTable("CurrentActivedWorkOrderInformation", "core");

            entity.Property(e => e.ActiveDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.ActiveUser).WithMany(p => p.CurrentActivedWorkOrderInformations)
                .HasForeignKey(d => d.ActiveUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrentActiveWorkOrderInformation_User");

            entity.HasOne(d => d.Cell).WithMany(p => p.CurrentActivedWorkOrderInformations)
                .HasForeignKey(d => d.CellId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrentActivedWorkOrderInformation_Cell");

            entity.HasOne(d => d.ProcessStep).WithMany(p => p.CurrentActivedWorkOrderInformations)
                .HasForeignKey(d => d.ProcessStepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrentActiveWorkOrderInformation_ProcessStep");

            entity.HasOne(d => d.Station).WithMany(p => p.CurrentActivedWorkOrderInformations)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrentActiveWorkOrderInformation_Station");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.CurrentActivedWorkOrderInformations)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrentActiveWorkOrderInformation_WorkOrder");
        });

        modelBuilder.Entity<CurrentToolingSetupInformation>(entity =>
        {
            entity.ToTable("CurrentToolingSetupInformation", "core");

            entity.Property(e => e.NestCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SetupDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.CurrentToolingSetupInformations)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_CurrentToolingSetupInformation_User");

            entity.HasOne(d => d.Station).WithMany(p => p.CurrentToolingSetupInformations)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrentToolingSetupInformation_Station");

            entity.HasOne(d => d.Tooling).WithMany(p => p.CurrentToolingSetupInformations)
                .HasForeignKey(d => d.ToolingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CurrentToolingSetupInformation_Tooling");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer", "core");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.ContactPerson).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DUNS)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PostCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Telphone)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.CustomerCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Customer_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.CustomerEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Customer_User1");
        });

        modelBuilder.Entity<CustomerBoxInformation>(entity =>
        {
            entity.ToTable("CustomerBoxInformation", "core");

            entity.Property(e => e.CustomerBoxNumber)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LinkDateTimed).HasColumnType("datetime");

            entity.HasOne(d => d.Container).WithMany(p => p.CustomerBoxInformations)
                .HasForeignKey(d => d.ContainerId)
                .HasConstraintName("FK_CustomerBoxInformation_Container");

            entity.HasOne(d => d.Creator).WithMany(p => p.CustomerBoxInformations)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_CustomerBoxInformation_User");

            entity.HasOne(d => d.MaterialOtherMovementFormItem).WithMany(p => p.CustomerBoxInformations)
                .HasForeignKey(d => d.MaterialOtherMovementFormItemId)
                .HasConstraintName("FK_CustomerBoxInformation_MaterialOtherMovementFormItem");

            entity.HasOne(d => d.ProductDeliveryRequestFormItem).WithMany(p => p.CustomerBoxInformations)
                .HasForeignKey(d => d.ProductDeliveryRequestFormItemId)
                .HasConstraintName("FK_CustomerBoxInformation_ProductDeliveryRequestForm");
        });

        modelBuilder.Entity<EDocument>(entity =>
        {
            entity.ToTable("EDocument", "edoc");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.DocumentCode).HasMaxLength(32);
            entity.Property(e => e.Name).HasMaxLength(1024);
            entity.Property(e => e.ValidBegin).HasColumnType("datetime");
            entity.Property(e => e.ValidEnd).HasColumnType("datetime");
            entity.Property(e => e.VersionNumber).HasMaxLength(32);

            entity.HasOne(d => d.DocumentType).WithMany(p => p.EDocuments)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EDocument_EDocumentType");

            entity.HasOne(d => d.Editor).WithMany(p => p.EDocumentEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_EDocument_User1");

            entity.HasOne(d => d.Initiator).WithMany(p => p.EDocumentInitiators)
                .HasForeignKey(d => d.InitiatorId)
                .HasConstraintName("FK_EDocument_User");
        });

        modelBuilder.Entity<EDocumentType>(entity =>
        {
            entity.ToTable("EDocumentType", "edoc");

            entity.Property(e => e.Description).HasMaxLength(32);
            entity.Property(e => e.Name).HasMaxLength(32);
        });

        modelBuilder.Entity<EDocument_Relationship>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EDocumentTypeRelationship");

            entity.ToTable("EDocument_Relationship", "edoc");

            entity.HasOne(d => d.Cell).WithMany(p => p.EDocument_Relationships)
                .HasForeignKey(d => d.CellId)
                .HasConstraintName("FK_EDocument_Relationship_Cell");

            entity.HasOne(d => d.EDocument).WithMany(p => p.EDocument_Relationships)
                .HasForeignKey(d => d.EDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EDocument_Relationship_EDocument");

            entity.HasOne(d => d.Material).WithMany(p => p.EDocument_Relationships)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_EDocument_Relationship_Material");

            entity.HasOne(d => d.ProcessStep).WithMany(p => p.EDocument_Relationships)
                .HasForeignKey(d => d.ProcessStepId)
                .HasConstraintName("FK_EDocument_Relationship_ProcessStep");

            entity.HasOne(d => d.StationGroup).WithMany(p => p.EDocument_Relationships)
                .HasForeignKey(d => d.StationGroupId)
                .HasConstraintName("FK_EDocument_Relationship_StationGroup");

            entity.HasOne(d => d.Station).WithMany(p => p.EDocument_Relationships)
                .HasForeignKey(d => d.StationId)
                .HasConstraintName("FK_EDocument_Relationship_Station");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.EDocument_Relationships)
                .HasForeignKey(d => d.WorkOrderId)
                .HasConstraintName("FK_EDocument_Relationship_WorkOrder");
        });

        modelBuilder.Entity<ERPMaterialHi>(entity =>
        {
            entity.ToTable("ERPMaterialHis", "tran");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.MaterialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RESULTMSG)
                .HasMaxLength(255)
                .IsFixedLength();
            entity.Property(e => e.RESULTSTATUS)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.Specification).HasMaxLength(200);
            entity.Property(e => e.creationDatetime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ERPWorkOrderHi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ERPWorkOrderHis_1");

            entity.ToTable("ERPWorkOrderHis", "tran");

            entity.Property(e => e.AUART)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasComment("订单类型");
            entity.Property(e => e.AUFNR)
                .HasMaxLength(12)
                .IsFixedLength()
                .HasComment("生产订单号");
            entity.Property(e => e.ERNAM)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.FTRMI)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.GLTRS)
                .HasComment("基本结束日期")
                .HasColumnType("datetime");
            entity.Property(e => e.GSTRP)
                .HasComment("基本开始日期")
                .HasColumnType("datetime");
            entity.Property(e => e.MAKTX)
                .HasMaxLength(40)
                .IsFixedLength()
                .HasComment("物料描述");
            entity.Property(e => e.MATNR)
                .HasMaxLength(40)
                .IsFixedLength()
                .HasComment("物料");
            entity.Property(e => e.MEINS)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PSMNG).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RESULTMSG)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasComment("消息文本");
            entity.Property(e => e.RESULTSTATUS)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("消息类型");
            entity.Property(e => e.WERKS)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasComment("工厂");
            entity.Property(e => e.creationDatetime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.ToTable("Event", "ievent");

            entity.Property(e => e.ActionFinishedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ActionStartedDateTime).HasColumnType("datetime");
            entity.Property(e => e.AssignedDateTime).HasColumnType("datetime");
            entity.Property(e => e.EventCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IssueDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReportDateTime).HasColumnType("datetime");
            entity.Property(e => e.SignedOffDateTime).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.ActionOwner).WithMany(p => p.EventActionOwners)
                .HasForeignKey(d => d.ActionOwnerId)
                .HasConstraintName("FK_Event_User1");

            entity.HasOne(d => d.ActionOwnerRole).WithMany(p => p.Events)
                .HasForeignKey(d => d.ActionOwnerRoleId)
                .HasConstraintName("FK_Event_Role");

            entity.HasOne(d => d.Area).WithMany(p => p.Events)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("FK_Event_Area");

            entity.HasOne(d => d.EventCategory).WithMany(p => p.Events)
                .HasForeignKey(d => d.EventCategoryId)
                .HasConstraintName("FK_Event_EventCatetory");

            entity.HasOne(d => d.EventSymptom).WithMany(p => p.Events)
                .HasForeignKey(d => d.EventSymptomId)
                .HasConstraintName("FK_Event_EventSymptom");

            entity.HasOne(d => d.Factory).WithMany(p => p.Events)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_Event_Factory");

            entity.HasOne(d => d.ReportUser).WithMany(p => p.EventReportUsers)
                .HasForeignKey(d => d.ReportUserId)
                .HasConstraintName("FK_Event_User");

            entity.HasOne(d => d.Signer).WithMany(p => p.EventSigners)
                .HasForeignKey(d => d.SignerId)
                .HasConstraintName("FK_Event_User2");

            entity.HasOne(d => d.Station).WithMany(p => p.Events)
                .HasForeignKey(d => d.StationId)
                .HasConstraintName("FK_Event_Station");
        });

        modelBuilder.Entity<EventActionRecord>(entity =>
        {
            entity.ToTable("EventActionRecord", "ievent");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.ActionUser).WithMany(p => p.EventActionRecords)
                .HasForeignKey(d => d.ActionUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventActionRecord_User");

            entity.HasOne(d => d.Event).WithMany(p => p.EventActionRecords)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventActionRecord_Event");
        });

        modelBuilder.Entity<EventCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EventCatetory");

            entity.ToTable("EventCategory", "ievent");

            entity.Property(e => e.CategoryCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.DefaultEscalationProcess).WithMany(p => p.EventCategories)
                .HasForeignKey(d => d.DefaultEscalationProcessId)
                .HasConstraintName("FK_EventCategory_EventEscalationProcess");

            entity.HasOne(d => d.DefaultOwnerRole).WithMany(p => p.EventCategories)
                .HasForeignKey(d => d.DefaultOwnerRoleId)
                .HasConstraintName("FK_EventCatetory_Role");

            entity.HasOne(d => d.Factory).WithMany(p => p.EventCategories)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_EventCatetory_Factory");
        });

        modelBuilder.Entity<EventEscalationProcess>(entity =>
        {
            entity.ToTable("EventEscalationProcess", "ievent");

            entity.Property(e => e.CreationDatetime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.EscalationProcessCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Creator).WithMany(p => p.EventEscalationProcessCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_EventEscalationProcess_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.EventEscalationProcessEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_EventEscalationProcess_User1");
        });

        modelBuilder.Entity<EventEscalationProcessStep>(entity =>
        {
            entity.ToTable("EventEscalationProcessStep", "ievent");

            entity.Property(e => e.TimeThresholdInSecond).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.EscalationProcess).WithMany(p => p.EventEscalationProcessSteps)
                .HasForeignKey(d => d.EscalationProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventEscalationProcessStep_EventEscalationProcess");

            entity.HasOne(d => d.RoleIdToInformNavigation).WithMany(p => p.EventEscalationProcessSteps)
                .HasForeignKey(d => d.RoleIdToInform)
                .HasConstraintName("FK_EventEscalationProcessStep_Role");
        });

        modelBuilder.Entity<EventEvaluationRecord>(entity =>
        {
            entity.ToTable("EventEvaluationRecord", "ievent");

            entity.Property(e => e.Comment).HasMaxLength(200);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Evaluator).WithMany(p => p.EventEvaluationRecords)
                .HasForeignKey(d => d.EvaluatorId)
                .HasConstraintName("FK_EventEvaluationRecord_User");

            entity.HasOne(d => d.Event).WithMany(p => p.EventEvaluationRecords)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventEvaluationRecord_Event");
        });

        modelBuilder.Entity<EventKnowledgeLibrary>(entity =>
        {
            entity.ToTable("EventKnowledgeLibrary", "ievent");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.KnowledgeCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Creator).WithMany(p => p.EventKnowledgeLibraries)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_EventKnowledgeLibrary_User");
        });

        modelBuilder.Entity<EventProblemTag>(entity =>
        {
            entity.ToTable("EventProblemTag", "ievent");

            entity.Property(e => e.TagName).HasMaxLength(50);
        });

        modelBuilder.Entity<EventProcessChangeDetail>(entity =>
        {
            entity.ToTable("EventProcessChangeDetail", "ievent");

            entity.Property(e => e.Property)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.EventProcessLog).WithMany(p => p.EventProcessChangeDetails)
                .HasForeignKey(d => d.EventProcessLogId)
                .HasConstraintName("FK_EventProcessChangeDetail_EventProcessChangeLog");
        });

        modelBuilder.Entity<EventProcessChangeLog>(entity =>
        {
            entity.ToTable("EventProcessChangeLog", "ievent");

            entity.Property(e => e.ChangeDateTime).HasColumnType("datetime");
            entity.Property(e => e.ChangeType).HasComment("1:");

            entity.HasOne(d => d.ChangeUser).WithMany(p => p.EventProcessChangeLogs)
                .HasForeignKey(d => d.ChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventProcessChangeLog_User");

            entity.HasOne(d => d.Event).WithMany(p => p.EventProcessChangeLogs)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventProcessChangeLog_Event");
        });

        modelBuilder.Entity<EventSubscription>(entity =>
        {
            entity.ToTable("EventSubscription", "ievent");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.EventSubscriptionCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_EventSubscription_User1");

            entity.HasOne(d => d.Editor).WithMany(p => p.EventSubscriptionEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_EventSubscription_User2");

            entity.HasOne(d => d.EventCategory).WithMany(p => p.EventSubscriptions)
                .HasForeignKey(d => d.EventCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventSubscription_EventCategory");

            entity.HasOne(d => d.EventSymptom).WithMany(p => p.EventSubscriptions)
                .HasForeignKey(d => d.EventSymptomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventSubscription_EventSymptom");

            entity.HasOne(d => d.SubscriberRole).WithMany(p => p.EventSubscriptions)
                .HasForeignKey(d => d.SubscriberRoleId)
                .HasConstraintName("FK_EventSubscription_Role");

            entity.HasOne(d => d.SubscriberUser).WithMany(p => p.EventSubscriptionSubscriberUsers)
                .HasForeignKey(d => d.SubscriberUserId)
                .HasConstraintName("FK_EventSubscription_User");
        });

        modelBuilder.Entity<EventSymptom>(entity =>
        {
            entity.ToTable("EventSymptom", "ievent");

            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.SymptomCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Factory).WithMany(p => p.EventSymptoms)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_EventSymptom_Factory");
        });

        modelBuilder.Entity<Event_KnowledgeLib>(entity =>
        {
            entity.ToTable("Event_KnowledgeLib", "ievent");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Event).WithMany(p => p.Event_KnowledgeLibs)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Event_KnowledgeLib_Event");

            entity.HasOne(d => d.KnowledgeLib).WithMany(p => p.Event_KnowledgeLibs)
                .HasForeignKey(d => d.KnowledgeLibId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Event_KnowledgeLib_EventKnowledgeLibrary");
        });

        modelBuilder.Entity<FISWorkOrder>(entity =>
        {
            entity.ToTable("FISWorkOrder", "fis");

            entity.Property(e => e.AverageCycleTime)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 3)");
            entity.Property(e => e.LastUpdateDateTime).HasColumnType("datetime");
            entity.Property(e => e.OEE)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TotalFailQuantity)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TotalGoodProductsQuantity).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TotalInputProducts)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TotalPassQuantity)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TotalScrapQuantity)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 3)");

            entity.HasOne(d => d.ProcessStep).WithMany(p => p.FISWorkOrders)
                .HasForeignKey(d => d.ProcessStepId)
                .HasConstraintName("FK_FISWorkOrder_ProcessStep");

            entity.HasOne(d => d.Station).WithMany(p => p.FISWorkOrders)
                .HasForeignKey(d => d.StationId)
                .HasConstraintName("FK_FISWorkOrder_Station");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.FISWorkOrders)
                .HasForeignKey(d => d.WorkOrderId)
                .HasConstraintName("FK_FISWorkOrder_WorkOrder");
        });

        modelBuilder.Entity<Factory>(entity =>
        {
            entity.ToTable("Factory", "core");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.FactoryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.Company).WithMany(p => p.Factories)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Factory_Company");
        });

        modelBuilder.Entity<FailureCause>(entity =>
        {
            entity.ToTable("FailureCause", "core");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FailureCauseCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<FailureCause_Station>(entity =>
        {
            entity.ToTable("FailureCause_Station", "core");

            entity.Property(e => e.AssignedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.FailureCause).WithMany(p => p.FailureCause_Stations)
                .HasForeignKey(d => d.FailureCauseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FailureCause_Station_FailureCause");

            entity.HasOne(d => d.Station).WithMany(p => p.FailureCause_Stations)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FailureCause_Station_Station");
        });

        modelBuilder.Entity<FailureSlip>(entity =>
        {
            entity.ToTable("FailureSlip", "trace");

            entity.Property(e => e.Content).HasColumnType("ntext");

            entity.HasOne(d => d.PartProcessRecord).WithMany(p => p.FailureSlips)
                .HasForeignKey(d => d.PartProcessRecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FailureSlip_PartProcessRecord");
        });

        modelBuilder.Entity<FailureType>(entity =>
        {
            entity.ToTable("FailureType", "core");

            entity.Property(e => e.CategoryId).HasComment("1:工废，2：料废");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FailureCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<FailureType_Station>(entity =>
        {
            entity.ToTable("FailureType_Station", "core");

            entity.Property(e => e.AssignedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.FailureType).WithMany(p => p.FailureType_Stations)
                .HasForeignKey(d => d.FailureTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FailureType_Station_FailureType");

            entity.HasOne(d => d.Station).WithMany(p => p.FailureType_Stations)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FailureType_Station_Station");
        });

        modelBuilder.Entity<FormType>(entity =>
        {
            entity.ToTable("FormType", "wms");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FormTypeCode).HasMaxLength(30);
            entity.Property(e => e.HasForm).HasComment("是否有表单");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.State).HasComment("1:Active,0:Deactive");
        });

        modelBuilder.Entity<IPQCForm>(entity =>
        {
            entity.ToTable("IPQCForm", "qms");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.IPQCFormCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.IPQCFormCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IPQCForm_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.IPQCFormEditors)
                .HasForeignKey(d => d.EditorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IPQCForm_User1");

            entity.HasOne(d => d.PartSerialNumber).WithMany(p => p.IPQCForms)
                .HasForeignKey(d => d.PartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IPQCForm_PartSerialNumber");

            entity.HasOne(d => d.Recipe).WithMany(p => p.IPQCForms)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IPQCForm_Recipe");
        });

        modelBuilder.Entity<IPQCRecord>(entity =>
        {
            entity.ToTable("IPQCRecord", "qms");

            entity.Property(e => e.DataFileURI).HasMaxLength(255);
            entity.Property(e => e.PlainText).HasColumnType("text");
            entity.Property(e => e.ProfileValues)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDateTime).HasColumnType("datetime");
            entity.Property(e => e.State).HasComment("0:未检验,1:检验中,2:PASS,3:FAIL");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.Editor).WithMany(p => p.IPQCRecords)
                .HasForeignKey(d => d.EditorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IPQCRecord_User");

            entity.HasOne(d => d.IPQCForm).WithMany(p => p.IPQCRecords)
                .HasForeignKey(d => d.IPQCFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IPQCRecord_IPQCForm");

            entity.HasOne(d => d.RecipeItem).WithMany(p => p.IPQCRecords)
                .HasForeignKey(d => d.RecipeItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IPQCRecord_RecipeItem");
        });

        modelBuilder.Entity<IQCForm>(entity =>
        {
            entity.ToTable("IQCForm", "qms");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.IQCFormCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lot).HasMaxLength(100);
            entity.Property(e => e.OrderNumber).HasMaxLength(50);

            entity.HasOne(d => d.Creator).WithMany(p => p.IQCFormCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IQCForm_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.IQCFormEditors)
                .HasForeignKey(d => d.EditorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IQCForm_User1");

            entity.HasOne(d => d.Material).WithMany(p => p.IQCForms)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IQCForm_Material");

            entity.HasOne(d => d.Recipe).WithMany(p => p.IQCForms)
                .HasForeignKey(d => d.RecipeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IQCForm_Recipe");

            entity.HasOne(d => d.Supplier).WithMany(p => p.IQCForms)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IQCForm_Supplier");
        });

        modelBuilder.Entity<IQCRecord>(entity =>
        {
            entity.ToTable("IQCRecord", "qms");

            entity.Property(e => e.DataFileURI).HasMaxLength(255);
            entity.Property(e => e.PlainText).HasColumnType("text");
            entity.Property(e => e.ProfileValues)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDateTime).HasColumnType("datetime");
            entity.Property(e => e.State).HasComment("0:未测试,1:检验中,2:PASS,3:FAIL");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.Editor).WithMany(p => p.IQCRecords)
                .HasForeignKey(d => d.EditorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IQCRecord_User");

            entity.HasOne(d => d.IQCForm).WithMany(p => p.IQCRecords)
                .HasForeignKey(d => d.IQCFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IQCRecord_IQCForm");

            entity.HasOne(d => d.RecipeItem).WithMany(p => p.IQCRecords)
                .HasForeignKey(d => d.RecipeItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IQCRecord_RecipeItem");
        });

        modelBuilder.Entity<IdCounter>(entity =>
        {
            entity.ToTable("IdCounter", "core", tb => tb.HasComment("Id模块的计数器"));

            entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.IdModel).WithMany(p => p.IdCounters)
                .HasForeignKey(d => d.IdModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IdCounter_IdModel");

            entity.HasOne(d => d.MaterialGroup).WithMany(p => p.IdCounters)
                .HasForeignKey(d => d.MaterialGroupId)
                .HasConstraintName("FK_IdCounter_MaterialGroup");

            entity.HasOne(d => d.Material).WithMany(p => p.IdCounters)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_IdCounter_Material");

            entity.HasOne(d => d.Station).WithMany(p => p.IdCounters)
                .HasForeignKey(d => d.StationId)
                .HasConstraintName("FK_IdCounter_Station");
        });

        modelBuilder.Entity<IdLayout>(entity =>
        {
            entity.ToTable("IdLayout", "core");

            entity.Property(e => e.AllowSpecialCharacters).HasComment("默认为False，即只允许0-9,a-z,A-Z");
            entity.Property(e => e.FillCharacter)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FillPrefixOrSuffix).HasComment("True:Fill at prefix, False: Fill at suffix");
            entity.Property(e => e.Type).HasComment("0:Counter,1:MaterialGroupNumber,2:MaterialGroupId,3:DateTimeTemplate,4:FreeText,5:NumericId,6:ObjectId,7:Attribute,8:MaterialNumber,9:MaterialId,10:ShiftName,11:StationParameter,12:WorkOrderNumber,13:ShiftDateTimeTemplate");
            entity.Property(e => e.Value)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdModel).WithMany(p => p.IdLayouts)
                .HasForeignKey(d => d.IdModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IdLayout_IdModel");
        });

        modelBuilder.Entity<IdModel>(entity =>
        {
            entity.ToTable("IdModel", "core");

            entity.Property(e => e.CounterFrom).HasComment("都换算为10进制后填写");
            entity.Property(e => e.CounterIdFormatType).HasComment("1:Dec,2:Hex,3:Alphanumerical");
            entity.Property(e => e.CounterManagementType).HasComment("1:Joint(所有物料，物料组用共用一个Counter，可按Station区分),2:Material(一种物料一个Counter,如果IsStationRelated=True的情况下，每个工站再区分Counter),3:MaterialGroup(一个MaterialGroup共享一个Conter,如果IsStationRelated是True的情况，通过Station区分)\r\n如果IdModel分配给PartGroup，然后这里CounterManagementType是Material的话，Counter会按Material区分开，如果还有Station的话也再进行区分。");
            entity.Property(e => e.CounterTo).HasComment("都换算为10进制后填写");
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.ModelName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResetCounterType).HasComment("0:Never,1:Daily,2:Weekly,3:Monthly,4:Yearly,5:WorkOrder,6:Shift");
            entity.Property(e => e.State).HasComment("0:Deactive, 1:Active");
            entity.Property(e => e.ValidFrom).HasColumnType("datetime");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.IdModelCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IdModel_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.IdModelEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_IdModel_User1");
        });

        modelBuilder.Entity<IdModelAssignment>(entity =>
        {
            entity.ToTable("IdModelAssignment", "core");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.EntityId).HasComment("Material或者MaterialGroup的EntityId");
            entity.Property(e => e.EntityType).HasComment("1:MaterialGroup,2:Material\r\n  如果IdModel同时分配给Material和MaterialGroup，Material的IdModel优先。");

            entity.HasOne(d => d.IdModel).WithMany(p => p.IdModelAssignments)
                .HasForeignKey(d => d.IdModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IdModelAssignment_IdModel");
        });

        modelBuilder.Entity<JPH>(entity =>
        {
            entity.ToTable("JPH", "core");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.JPH1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("JPH");

            entity.HasOne(d => d.Creator).WithMany(p => p.JPHCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JPH_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.JPHEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_JPH_User1");

            entity.HasOne(d => d.LineLocation).WithMany(p => p.JPHs)
                .HasForeignKey(d => d.LineLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JPH_Location");

            entity.HasOne(d => d.Material).WithMany(p => p.JPHs)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JPH_Material");
        });

        modelBuilder.Entity<KnowledgeLib_ProblemTag>(entity =>
        {
            entity.ToTable("KnowledgeLib_ProblemTag", "ievent");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.EventKnowledgeLib).WithMany(p => p.KnowledgeLib_ProblemTags)
                .HasForeignKey(d => d.EventKnowledgeLibId)
                .HasConstraintName("FK_KnowledgeLib_ProblemTag_EventKnowledgeLibrary");

            entity.HasOne(d => d.EventProblemTag).WithMany(p => p.KnowledgeLib_ProblemTags)
                .HasForeignKey(d => d.EventProblemTagId)
                .HasConstraintName("FK_KnowledgeLib_ProblemTag_EventProblemTag");
        });

        modelBuilder.Entity<Line>(entity =>
        {
            entity.ToTable("Line", "core");

            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.LineCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("Location", "core");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.LocationNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type).HasComment("0: 实体库位(比如货架)1:虚拟库, 2:, 3:ECALL线体");

            entity.HasOne(d => d.Area).WithMany(p => p.Locations)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("FK_Location_Area");

            entity.HasOne(d => d.Creator).WithMany(p => p.LocationCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Location_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.LocationEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Location_User1");
        });

        modelBuilder.Entity<LockUnlockPartSNRecord>(entity =>
        {
            entity.ToTable("LockUnlockPartSNRecord", "qms");

            entity.Property(e => e.Id).HasComment("1:立即锁定,2:未来锁定,0:解锁");
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.LockOrUnLock).HasComment("1:锁定,2:解锁");
            entity.Property(e => e.LockType).HasComment("1:Lock immediately, 2:Lock in future");

            entity.HasOne(d => d.Creator).WithMany(p => p.LockUnlockPartSNRecords)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LockUnlockPartSNRecord_User");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.LockUnlockPartSNRecords)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LockUnlockPartSNRecord_WorkOrder");
        });

        modelBuilder.Entity<LockUnlockPartSNRecord_PartSerialNumber>(entity =>
        {
            entity.ToTable("LockUnlockPartSNRecord_PartSerialNumber", "qms");

            entity.HasOne(d => d.LockUnlockPartSNRecord).WithMany(p => p.LockUnlockPartSNRecord_PartSerialNumbers)
                .HasForeignKey(d => d.LockUnlockPartSNRecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LockUnlockPartSNRecord_PartSerialNumber_LockUnlockPartSNRecord");

            entity.HasOne(d => d.PartSerialNumber).WithMany(p => p.LockUnlockPartSNRecord_PartSerialNumbers)
                .HasForeignKey(d => d.PartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LockUnlockPartSNRecord_PartSerialNumber_PartSerialNumber");
        });

        modelBuilder.Entity<MESParameterReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MESParameterTemplate");

            entity.ToTable("MESParameterReference", "core");

            entity.Property(e => e.AllowedValues).HasComment("分隔符用|");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ParameterCode).HasMaxLength(200);
            entity.Property(e => e.ParameterName).HasMaxLength(100);
            entity.Property(e => e.ParameterType).HasComment("1:ServerParameter,2:CompanyParameter,3:FactoryParameter,4:AreaParameter,5:CellParameter,6:StationGroupParameter,7:StationParameter");
            entity.Property(e => e.ParameterValueType).HasComment("1:Object,2:String,3:Boolean,4:Integer,5:Long,6:Float,7:Double,8:Decimal");
        });

        modelBuilder.Entity<MSATest>(entity =>
        {
            entity.ToTable("MSATest");

            entity.Property(e => e.AV).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Cp).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Cpk).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.EV).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.FinalResult).HasMaxLength(50);
            entity.Property(e => e.GRR).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ItemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LCL).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LSL).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Norm).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PV).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PlanDateTime).HasColumnType("datetime");
            entity.Property(e => e.R).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RBarBar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ResultDateTime).HasColumnType("datetime");
            entity.Property(e => e.TV).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UCL).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.USL).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.XBarBar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.XMax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.XMin).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Creator).WithMany(p => p.MSATestCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_MSATest_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.MSATestEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_MSATest_User1");

            entity.HasOne(d => d.Machine).WithMany(p => p.MSATests)
                .HasForeignKey(d => d.MachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MSATest_Machine");

            entity.HasOne(d => d.Unit).WithMany(p => p.MSATests)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_MSATest_Unit");
        });

        modelBuilder.Entity<MSATestRecord>(entity =>
        {
            entity.ToTable("MSATestRecord");

            entity.Property(e => e.R).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SampleSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Standard).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TestDateTime).HasColumnType("datetime");
            entity.Property(e => e.TestResult).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Xbar).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.MSATest).WithMany(p => p.MSATestRecords)
                .HasForeignKey(d => d.MSATestId)
                .HasConstraintName("FK_MSATestRecord_MSATest");

            entity.HasOne(d => d.Operator).WithMany(p => p.MSATestRecords)
                .HasForeignKey(d => d.OperatorId)
                .HasConstraintName("FK_MSATestRecord_User");

            entity.HasOne(d => d.Sample).WithMany(p => p.MSATestRecords)
                .HasForeignKey(d => d.SampleId)
                .HasConstraintName("FK_MSATestRecord_PartSerialNumber");
        });

        modelBuilder.Entity<MSL>(entity =>
        {
            entity.ToTable("MSL", "core");

            entity.Property(e => e.Name)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Machine>(entity =>
        {
            entity.ToTable("Machine", "core");

            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.CurrentJobCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrentJobName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentPartCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CurrentPartInputDateTime).HasColumnType("datetime");
            entity.Property(e => e.CurrentPartSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrentPartType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.IPV4Address)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastPartCycleTime).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.LastPartOutputDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastPartSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MachineCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OperatorCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RoutingCode)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.MachineCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Machine_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.MachineEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Machine_User1");

            entity.HasOne(d => d.Station).WithMany(p => p.Machines)
                .HasForeignKey(d => d.StationId)
                .HasConstraintName("FK_Machine_Station");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Machines)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Machine_Supplier");
        });

        modelBuilder.Entity<MachineConfiguration>(entity =>
        {
            entity.ToTable("MachineConfiguration", "nbproj");

            entity.Property(e => e.IPV4Address)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.MachineCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StationNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MachineCurrentToolingSetupDatum>(entity =>
        {
            entity.ToTable("MachineCurrentToolingSetupData", "core");

            entity.Property(e => e.SetupDateTime).HasColumnType("datetime");
            entity.Property(e => e.ToolingHoleNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Machine).WithMany(p => p.MachineCurrentToolingSetupData)
                .HasForeignKey(d => d.MachineId)
                .HasConstraintName("FK_MachineCurrentToolingSetupData_Machine");

            entity.HasOne(d => d.Operator).WithMany(p => p.MachineCurrentToolingSetupData)
                .HasForeignKey(d => d.OperatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MachineCurrentToolingSetupData_User");

            entity.HasOne(d => d.Station).WithMany(p => p.MachineCurrentToolingSetupData)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MachineCurrentToolingSetupData_Station");

            entity.HasOne(d => d.Tooling).WithMany(p => p.MachineCurrentToolingSetupData)
                .HasForeignKey(d => d.ToolingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MachineCurrentToolingSetupData_Tooling");
        });

        modelBuilder.Entity<MachineErrorInformation>(entity =>
        {
            entity.ToTable("MachineErrorInformation", "nbproj");

            entity.Property(e => e.ErrorCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ErrorSourceId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FixedDateTime).HasColumnType("datetime");
            entity.Property(e => e.OccuredDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<MachineMessageLog>(entity =>
        {
            entity.ToTable("MachineMessageLog", "tpm");

            entity.Property(e => e.Commemt).HasMaxLength(255);
            entity.Property(e => e.LogDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Machine).WithMany(p => p.MachineMessageLogs)
                .HasForeignKey(d => d.MachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MachineMessageLog_Machine");

            entity.HasOne(d => d.MessageType).WithMany(p => p.MachineMessageLogs)
                .HasForeignKey(d => d.MessageTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MachineMessageLog_MessageType");
        });

        modelBuilder.Entity<MachineRunningInformation>(entity =>
        {
            entity.ToTable("MachineRunningInformation", "nbproj");

            entity.Property(e => e.MachineNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartSN)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RunningState)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MaintenanceItem>(entity =>
        {
            entity.ToTable("MaintenanceItem", "tpm");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Materiel");

            entity.ToTable("Material", "core", tb => tb.HasComment(""));

            entity.Property(e => e.CADDrawingPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContainerNumberRegEx).HasMaxLength(200);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.CustomerMaterialNumber).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExpirationTime).HasColumnType("decimal(19, 0)");
            entity.Property(e => e.MaterialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MinimumPackageQuantity).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.NumberOfPanels).HasDefaultValue(1);
            entity.Property(e => e.OriginalNumber)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProjectName).HasMaxLength(50);
            entity.Property(e => e.SafetyStock).HasColumnType("decimal(15, 0)");
            entity.Property(e => e.Specification).HasMaxLength(200);
            entity.Property(e => e.State).HasComment("0:Deactive, 1:Active");
            entity.Property(e => e.SupplierMaterialNumber).HasMaxLength(50);
            entity.Property(e => e.ValidBegin).HasColumnType("datetime");
            entity.Property(e => e.ValidEnd).HasColumnType("datetime");

            entity.HasOne(d => d.Company).WithMany(p => p.Materials)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Materiel_Company");

            entity.HasOne(d => d.Creator).WithMany(p => p.Materials)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Materiel_User");

            entity.HasOne(d => d.DefaultStationGroup).WithMany(p => p.Materials)
                .HasForeignKey(d => d.DefaultStationGroupId)
                .HasConstraintName("FK_Materiel_StationGroup");

            entity.HasOne(d => d.DefaultStorageLocation).WithMany(p => p.MaterialDefaultStorageLocations)
                .HasForeignKey(d => d.DefaultStorageLocationId)
                .HasConstraintName("FK_Materiel_LocationStorage");

            entity.HasOne(d => d.DefaultTargetFeedingLocation).WithMany(p => p.MaterialDefaultTargetFeedingLocations)
                .HasForeignKey(d => d.DefaultTargetFeedingLocationId)
                .HasConstraintName("FK_Material_LocationFeeding");

            entity.HasOne(d => d.Factory).WithMany(p => p.Materials)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_Materiel_Factory");

            entity.HasOne(d => d.MSLNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.MSL)
                .HasConstraintName("FK_Materiel_MSL");

            entity.HasOne(d => d.MaterialGroupTypeNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.MaterialGroupType)
                .HasConstraintName("FK_Materiel_MaterialGroup");

            entity.HasOne(d => d.ProcurementTypeNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.ProcurementType)
                .HasConstraintName("FK_Materiel_ProcurementType");

            entity.HasOne(d => d.UnitNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.Unit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Materiel_Unit");
        });

        modelBuilder.Entity<MaterialCheckBillForm>(entity =>
        {
            entity.ToTable("MaterialCheckBillForm", "wms");

            entity.HasOne(d => d.CheckArea).WithMany(p => p.MaterialCheckBillForms)
                .HasForeignKey(d => d.CheckAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialCheckBillForm_Area");

            entity.HasOne(d => d.Form).WithMany(p => p.MaterialCheckBillForms)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialCheckBillForm_WMSForm");
        });

        modelBuilder.Entity<MaterialCheckBillFormItem>(entity =>
        {
            entity.ToTable("MaterialCheckBillFormItem", "wms");

            entity.Property(e => e.CheckQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ScannedQuantity).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.CheckLocation).WithMany(p => p.MaterialCheckBillFormItems)
                .HasForeignKey(d => d.CheckLocationId)
                .HasConstraintName("FK_MaterialCheckBillFormItem_Location");

            entity.HasOne(d => d.MaterialCheckBillForm).WithMany(p => p.MaterialCheckBillFormItems)
                .HasForeignKey(d => d.MaterialCheckBillFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialCheckBillFormItem_MaterialCheckBillForm");

            entity.HasOne(d => d.Material).WithMany(p => p.MaterialCheckBillFormItems)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_MaterialCheckBillFormItem_Material");

            entity.HasOne(d => d.Unit).WithMany(p => p.MaterialCheckBillFormItems)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_MaterialCheckBillFormItem_Unit");
        });

        modelBuilder.Entity<MaterialCheckInformation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MaterialCheckinformation");

            entity.ToTable("MaterialCheckInformation", "wms");

            entity.Property(e => e.CheckDateTime).HasColumnType("datetime");
            entity.Property(e => e.ScanQuantity).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Container).WithMany(p => p.MaterialCheckInformations)
                .HasForeignKey(d => d.ContainerId)
                .HasConstraintName("FK_MaterialCheckinformation_Container");

            entity.HasOne(d => d.MaterialCheckBillFormItem).WithMany(p => p.MaterialCheckInformations)
                .HasForeignKey(d => d.MaterialCheckBillFormItemId)
                .HasConstraintName("FK_MaterialCheckinformation_MaterialCheckBillFormItem");

            entity.HasOne(d => d.ScanLocation).WithMany(p => p.MaterialCheckInformations)
                .HasForeignKey(d => d.ScanLocationId)
                .HasConstraintName("FK_MaterialCheckinformation_Location");

            entity.HasOne(d => d.Stocktaker).WithMany(p => p.MaterialCheckInformations)
                .HasForeignKey(d => d.StocktakerId)
                .HasConstraintName("FK_MaterialCheckinformation_User");
        });

        modelBuilder.Entity<MaterialGroup>(entity =>
        {
            entity.ToTable("MaterialGroup", "core");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.MaterialGroupCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<MaterialOtherMovementForm>(entity =>
        {
            entity.ToTable("MaterialOtherMovementForm", "wms");

            entity.HasOne(d => d.Form).WithMany(p => p.MaterialOtherMovementForms)
                .HasForeignKey(d => d.FormId)
                .HasConstraintName("FK_MaterialOtherMovementForm_WMSForm");
        });

        modelBuilder.Entity<MaterialOtherMovementFormItem>(entity =>
        {
            entity.ToTable("MaterialOtherMovementFormItem", "wms");

            entity.Property(e => e.ReceivingScannedQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RequestQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ScannedQuantity).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Material).WithMany(p => p.MaterialOtherMovementFormItems)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_MaterialOtherMovementFormItem_Material");

            entity.HasOne(d => d.MaterialOtherMovementForm).WithMany(p => p.MaterialOtherMovementFormItems)
                .HasForeignKey(d => d.MaterialOtherMovementFormId)
                .HasConstraintName("FK_MaterialOtherMovementFormItem_MaterialOtherMovementForm");

            entity.HasOne(d => d.SourceArea).WithMany(p => p.MaterialOtherMovementFormItemSourceAreas)
                .HasForeignKey(d => d.SourceAreaId)
                .HasConstraintName("FK_MaterialOtherMovementFormItem_Area");

            entity.HasOne(d => d.SupplierArea).WithMany(p => p.MaterialOtherMovementFormItemSupplierAreas)
                .HasForeignKey(d => d.SupplierAreaId)
                .HasConstraintName("FK_MaterialOtherMovementFormItem_Area2");

            entity.HasOne(d => d.TargetArea).WithMany(p => p.MaterialOtherMovementFormItemTargetAreas)
                .HasForeignKey(d => d.TargetAreaId)
                .HasConstraintName("FK_MaterialOtherMovementFormItem_Area1");

            entity.HasOne(d => d.Unit).WithMany(p => p.MaterialOtherMovementFormItems)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_MaterialOtherMovementFormItem_Unit");
        });

        modelBuilder.Entity<MaterialPickingForm>(entity =>
        {
            entity.ToTable("MaterialPickingForm", "wms");

            entity.HasOne(d => d.Form).WithMany(p => p.MaterialPickingForms)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialPickingForm_WMSForm");

            entity.HasOne(d => d.PickingArea).WithMany(p => p.MaterialPickingForms)
                .HasForeignKey(d => d.PickingAreaId)
                .HasConstraintName("FK_MaterialPickingForm_Area");

            entity.HasOne(d => d.RequestLocation).WithMany(p => p.MaterialPickingForms)
                .HasForeignKey(d => d.RequestLocationId)
                .HasConstraintName("FK_MaterialPickingForm_Location");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.MaterialPickingForms)
                .HasForeignKey(d => d.WorkOrderId)
                .HasConstraintName("FK_MaterialPickingForm_WorkOrder");
        });

        modelBuilder.Entity<MaterialPickingFormItem>(entity =>
        {
            entity.ToTable("MaterialPickingFormItem", "wms");

            entity.Property(e => e.RequestQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ScannedQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.State).HasComment("-1:Cancel, 0:New, 1:Picking, 2:Completed");

            entity.HasOne(d => d.Material).WithMany(p => p.MaterialPickingFormItems)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialPickingFormItem_Material");

            entity.HasOne(d => d.MaterialPickingForm).WithMany(p => p.MaterialPickingFormItems)
                .HasForeignKey(d => d.MaterialPickingFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialPickingFormItem_MaterialPickingForm");

            entity.HasOne(d => d.PickingArea).WithMany(p => p.MaterialPickingFormItems)
                .HasForeignKey(d => d.PickingAreaId)
                .HasConstraintName("FK_MaterialPickingFormItem_Area");

            entity.HasOne(d => d.RequestLocation).WithMany(p => p.MaterialPickingFormItems)
                .HasForeignKey(d => d.RequestLocationId)
                .HasConstraintName("FK_MaterialPickingFormItem_Location");

            entity.HasOne(d => d.Unit).WithMany(p => p.MaterialPickingFormItems)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialPickingFormItem_Unit");
        });

        modelBuilder.Entity<MaterialPool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MaterialPoolRecord");

            entity.ToTable("MaterialPool", "core");

            entity.Property(e => e.Designator)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FeederLocation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("SMTFeeder的位置号");
            entity.Property(e => e.Layer).HasComment("0:TOP,1:BOT,2:Indepent");
            entity.Property(e => e.SetupDateTime).HasColumnType("datetime");
            entity.Property(e => e.SetupName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Container).WithMany(p => p.MaterialPools)
                .HasForeignKey(d => d.ContainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialPool_Container");

            entity.HasOne(d => d.SetupOperator).WithMany(p => p.MaterialPools)
                .HasForeignKey(d => d.SetupOperatorId)
                .HasConstraintName("FK_MaterialPool_User");

            entity.HasOne(d => d.Station).WithMany(p => p.MaterialPools)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialPool_Station");
        });

        modelBuilder.Entity<MaterialQueue>(entity =>
        {
            entity.ToTable("MaterialQueue", "nbproj");

            entity.Property(e => e.LineCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("对应的是Cell表的CellNumber");
            entity.Property(e => e.MarkedDateTime).HasColumnType("datetime");
            entity.Property(e => e.MarkedResult)
                .HasDefaultValue(-1)
                .HasComment("-1:还未打标,0:打标OK,1:打标Fail");
            entity.Property(e => e.MarkedSN)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaterialContainerNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MaterialNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MaterialSetupDateTime).HasColumnType("datetime");
            entity.Property(e => e.VariantCode)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MaterialReceivingForm>(entity =>
        {
            entity.ToTable("MaterialReceivingForm", "wms");

            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Form).WithMany(p => p.MaterialReceivingForms)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReceivingForm_WMSForm");
        });

        modelBuilder.Entity<MaterialReceivingFormItem>(entity =>
        {
            entity.ToTable("MaterialReceivingFormItem", "wms");

            entity.Property(e => e.BatchNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpireDateTime).HasColumnType("datetime");
            entity.Property(e => e.ManufacturingDateTime).HasColumnType("datetime");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ReceivingQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ScannedQuantity).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Material).WithMany(p => p.MaterialReceivingFormItems)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReceivingFormItem_Material");

            entity.HasOne(d => d.MaterialReceivingForm).WithMany(p => p.MaterialReceivingFormItems)
                .HasForeignKey(d => d.MaterialReceivingFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReceivingFormItem_MaterialReceivingForm");

            entity.HasOne(d => d.Receiver).WithMany(p => p.MaterialReceivingFormItems)
                .HasForeignKey(d => d.ReceiverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReceivingFormItem_User");

            entity.HasOne(d => d.ReceivingLocation).WithMany(p => p.MaterialReceivingFormItems)
                .HasForeignKey(d => d.ReceivingLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReceivingFormItem_Location");

            entity.HasOne(d => d.Supplier).WithMany(p => p.MaterialReceivingFormItems)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReceivingFormItem_Supplier");

            entity.HasOne(d => d.Unit).WithMany(p => p.MaterialReceivingFormItems)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReceivingFormItem_Unit");
        });

        modelBuilder.Entity<MaterialRequestForm>(entity =>
        {
            entity.ToTable("MaterialRequestForm", "wms");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.MaterialRequestFormNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequiredOnBoardDateTime).HasColumnType("datetime");
            entity.Property(e => e.State).HasComment("-1:撤销,1:新,2配货种:,3:已配货,");

            entity.HasOne(d => d.Creator).WithMany(p => p.MaterialRequestFormCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestForm_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.MaterialRequestFormEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_MaterialRequestForm_User1");

            entity.HasOne(d => d.PickingArea).WithMany(p => p.MaterialRequestForms)
                .HasForeignKey(d => d.PickingAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestForm_Area");

            entity.HasOne(d => d.RequestLocation).WithMany(p => p.MaterialRequestForms)
                .HasForeignKey(d => d.RequestLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestForm_Location");
        });

        modelBuilder.Entity<MaterialRequestFormItem>(entity =>
        {
            entity.ToTable("MaterialRequestFormItem", "wms");

            entity.Property(e => e.Id).HasComment("-1:撤销,1:新,2配货种:,3:已配货,");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.State).HasComment("-1:Cancel, 1:New, 2:Picking, 3:Completed");

            entity.HasOne(d => d.DestinationLocation).WithMany(p => p.MaterialRequestFormItems)
                .HasForeignKey(d => d.DestinationLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestFormItem_Location");

            entity.HasOne(d => d.Material).WithMany(p => p.MaterialRequestFormItems)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialRequestFormItem_Material");

            entity.HasOne(d => d.MaterialRequestForm).WithMany(p => p.MaterialRequestFormItems)
                .HasForeignKey(d => d.MaterialRequestFormId)
                .HasConstraintName("FK_MaterialRequestFormItem_MaterialRequestForm");

            entity.HasOne(d => d.Unit).WithMany(p => p.MaterialRequestFormItems)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_MaterialRequestFormItem_Unit");
        });

        modelBuilder.Entity<MaterialRequestFormItem_MaterialPickingFormItem>(entity =>
        {
            entity.ToTable("MaterialRequestFormItem_MaterialPickingFormItem", "wms");

            entity.HasOne(d => d.MaterialPickingFormItem).WithMany(p => p.MaterialRequestFormItem_MaterialPickingFormItems)
                .HasForeignKey(d => d.MaterialPickingFormItemId)
                .HasConstraintName("FK_MaterialRequestFormItem_MaterialPickingFormItem_MaterialPickingFormItem");

            entity.HasOne(d => d.MaterialRequestFormItem).WithMany(p => p.MaterialRequestFormItem_MaterialPickingFormItems)
                .HasForeignKey(d => d.MaterialRequestFormItemId)
                .HasConstraintName("FK_MaterialRequestFormItem_MaterialPickingFormItem_MaterialRequestFormItem");
        });

        modelBuilder.Entity<MaterialReturnForm>(entity =>
        {
            entity.ToTable("MaterialReturnForm", "wms");

            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Form).WithMany(p => p.MaterialReturnForms)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReturnForm_WMSForm");

            entity.HasOne(d => d.Supplier).WithMany(p => p.MaterialReturnForms)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReturnForm_Supplier");
        });

        modelBuilder.Entity<MaterialReturnFormItem>(entity =>
        {
            entity.ToTable("MaterialReturnFormItem", "wms");

            entity.Property(e => e.ActualReturnQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BatchNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Material).WithMany(p => p.MaterialReturnFormItems)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReturnFormItem_Material");

            entity.HasOne(d => d.MaterialReturnForm).WithMany(p => p.MaterialReturnFormItems)
                .HasForeignKey(d => d.MaterialReturnFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReturnFormItem_MaterialReturnForm");

            entity.HasOne(d => d.Unit).WithMany(p => p.MaterialReturnFormItems)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialReturnFormItem_Unit");
        });

        modelBuilder.Entity<Material_Process>(entity =>
        {
            entity.ToTable("Material_Process", "tran");

            entity.Property(e => e.EditDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Material).WithMany(p => p.Material_Processes)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Material_Process_Material");

            entity.HasOne(d => d.Process).WithMany(p => p.Material_Processes)
                .HasForeignKey(d => d.ProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Material_Process_Process");
        });

        modelBuilder.Entity<Material_SupplierMaterialBarcode>(entity =>
        {
            entity.ToTable("Material_SupplierMaterialBarcode", "wms");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.SupplierMaterialBarcode)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.Material_SupplierMaterialBarcodes)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Material_SupplierMaterialBarcode_User");

            entity.HasOne(d => d.Material).WithMany(p => p.Material_SupplierMaterialBarcodes)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Material_SupplierMaterialBarcode_Material");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Material_SupplierMaterialBarcodes)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Material_SupplierMaterialBarcode_Supplier");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.ToTable("Menu", "core");

            entity.Property(e => e.Auth).HasMaxLength(4000);
            entity.Property(e => e.FontFamily).HasMaxLength(50);
            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Url).HasMaxLength(100);

            entity.HasOne(d => d.Creator).WithMany(p => p.MenuCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Menu_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.MenuEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Menu_User1");
        });

        modelBuilder.Entity<MessageType>(entity =>
        {
            entity.ToTable("MessageType", "core");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.MessageCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.MessageTypeCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MessageType_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.MessageTypeEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_MessageType_User1");
        });

        modelBuilder.Entity<MovementRecord>(entity =>
        {
            entity.ToTable("MovementRecord", "wms");

            entity.Property(e => e.MoveQuantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OperationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Container).WithMany(p => p.MovementRecords)
                .HasForeignKey(d => d.ContainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovementRecord_Container");

            entity.HasOne(d => d.DestinationLocation).WithMany(p => p.MovementRecordDestinationLocations)
                .HasForeignKey(d => d.DestinationLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovementRecord_Location1");

            entity.HasOne(d => d.OperationForm).WithMany(p => p.MovementRecords)
                .HasForeignKey(d => d.OperationFormId)
                .HasConstraintName("FK_MovementRecord_WMSForm");

            entity.HasOne(d => d.OperationFormType).WithMany(p => p.MovementRecords)
                .HasForeignKey(d => d.OperationFormTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovementRecord_FormType");

            entity.HasOne(d => d.Operator).WithMany(p => p.MovementRecords)
                .HasForeignKey(d => d.OperatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovementRecord_User");

            entity.HasOne(d => d.SourceLocation).WithMany(p => p.MovementRecordSourceLocations)
                .HasForeignKey(d => d.SourceLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovementRecord_Location");
        });

        modelBuilder.Entity<OperationStep>(entity =>
        {
            entity.ToTable("OperationStep", "core", tb => tb.HasComment("工艺步骤的工步"));

            entity.Property(e => e.Controller)
                .HasMaxLength(50)
                .HasComment("工步所控制的控制器，比如拧紧控制器1");
            entity.Property(e => e.ControllerType).HasComment("1:PLC,2:拧紧控制器,3:气密仪,4:压机");
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.ParameterName)
                .HasMaxLength(30)
                .HasComment("螺丝孔号/测量项名， 与RecipeItem.Name关联");
            entity.Property(e => e.ParameterValue).HasMaxLength(50);
            entity.Property(e => e.ProgramId).HasComment("调用控制器/PLC的程序/命令代号");
            entity.Property(e => e.Secquence).HasComment("");
            entity.Property(e => e.StepCode).HasMaxLength(50);
            entity.Property(e => e.StepType).HasComment("工步类型：1:手工,2:自动拧紧,3:气密测试,4:压装,5:涂胶,6:视觉检测");
            entity.Property(e => e.ThreadId).HasComment("都为同一个值的话，就代表多线程同时做的，对应到PLC的TaskId，例如：4个枪同时打，都是同一个ThreadId");

            entity.HasOne(d => d.Creator).WithMany(p => p.OperationStepCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_OperationStep_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.OperationStepEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_OperationStep_User1");

            entity.HasOne(d => d.Tooling).WithMany(p => p.OperationSteps)
                .HasForeignKey(d => d.ToolingId)
                .HasConstraintName("FK_OperationStep_Tooling");
        });

        modelBuilder.Entity<OrderConfirmation>(entity =>
        {
            entity.ToTable("OrderConfirmation", "tran");

            entity.Property(e => e.CompanyCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.DateTimeFrom).HasColumnType("datetime");
            entity.Property(e => e.DateTimeTo).HasColumnType("datetime");
            entity.Property(e => e.ErrorCode_ERP)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ErrorCode_MES)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ErrorMessage_ERP)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ErrorMessage_MES)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FactoryCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MaterialNumber)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.PassQuantity).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.ProcessStep_ERP)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ScrapQuantity).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Source).HasComment("1:MES->ERP, 2:ERP->MES");
            entity.Property(e => e.Stamp).HasColumnType("datetime");
            entity.Property(e => e.StationNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Status_ERP).HasComment("0:等待ERP处理，1：ERP正在处理，2：ERP处理完毕OK，-1：ERP处理出错");
            entity.Property(e => e.Status_MES).HasComment("0:等待MES处理，1：MES正在处理，2：MES处理完毕OK，-1：MES处理出错");
            entity.Property(e => e.TotalPassQuantity).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.TotalScrapQuantity).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.Transcation_Type).HasComment("1:Backflush");
            entity.Property(e => e.UserCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WorkOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PMCStationDataX>(entity =>
        {
            entity.ToTable("PMCStationDataX", "nbproj");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.DataName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DataValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direction).HasComment("1:PDA to PMC, 2:PMC to PDA");
            entity.Property(e => e.PDAId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PMCStationNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDateTime)
                .HasComment("PLCOPCClientHandler处理时间")
                .HasColumnType("datetime");
            entity.Property(e => e.State).HasComment("0: New, 2: Processed, -1: HasError");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PackingInformation>(entity =>
        {
            entity.ToTable("PackingInformation", "core");

            entity.Property(e => e.PackingDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Container).WithMany(p => p.PackingInformations)
                .HasForeignKey(d => d.ContainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PackingInformation_Container");

            entity.HasOne(d => d.Creator).WithMany(p => p.PackingInformations)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PackingInformation_User");

            entity.HasOne(d => d.PartSerialNumber).WithMany(p => p.PackingInformations)
                .HasForeignKey(d => d.PartSerialNumberId)
                .HasConstraintName("FK_PackingInformation_PartSerialNumber");
        });

        modelBuilder.Entity<PackingInformationHi>(entity =>
        {
            entity.ToTable("PackingInformationHis", "core");

            entity.Property(e => e.PackingDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<PartConfiguration>(entity =>
        {
            entity.ToTable("PartConfiguration", "nbproj");

            entity.Property(e => e.FinishGoodDrawingPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinishGoodPartDescription).HasMaxLength(50);
            entity.Property(e => e.FinishGoodPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RawMaterialDrawingPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RawMaterialPartDescription).HasMaxLength(50);
            entity.Property(e => e.RawMaterialPartNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VariantCode)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PartFailureDataRecord>(entity =>
        {
            entity.ToTable("PartFailureDataRecord", "trace");

            entity.Property(e => e.BookDateTime).HasColumnType("datetime");
            entity.Property(e => e.Comment).HasMaxLength(200);
            entity.Property(e => e.Designator)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductionDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.FailureCause).WithMany(p => p.PartFailureDataRecords)
                .HasForeignKey(d => d.FailureCauseId)
                .HasConstraintName("FK_PartFailureDataRecord_FailureCause");

            entity.HasOne(d => d.FailureType).WithMany(p => p.PartFailureDataRecords)
                .HasForeignKey(d => d.FailureTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartFailureDataRecord_FailureType");

            entity.HasOne(d => d.PartProcessRecord).WithMany(p => p.PartFailureDataRecords)
                .HasForeignKey(d => d.PartProcessRecordId)
                .HasConstraintName("FK_PartFailureDataRecord_PartProcessRecord");

            entity.HasOne(d => d.PartSerialNumber).WithMany(p => p.PartFailureDataRecords)
                .HasForeignKey(d => d.PartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartFailureDataRecord_PartSerialNumber");

            entity.HasOne(d => d.Station).WithMany(p => p.PartFailureDataRecords)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartFailureDataRecord_Station");
        });

        modelBuilder.Entity<PartLabelPrintRecord>(entity =>
        {
            entity.ToTable("PartLabelPrintRecord", "ProjAppleTrace");

            entity.Property(e => e.MaterialName).HasMaxLength(100);
            entity.Property(e => e.MaterialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaterialSpecification).HasMaxLength(100);
            entity.Property(e => e.OperatorAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OperatorName).HasMaxLength(50);
            entity.Property(e => e.PartSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrintDateTime).HasColumnType("datetime");
            entity.Property(e => e.PrintType).HasComment("1:NewPrint,2:RePrint");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StationNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UnitName).HasMaxLength(10);
            entity.Property(e => e.WorkOrderCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PartMaterialRecord>(entity =>
        {
            entity.ToTable("PartMaterialRecord", "trace");

            entity.Property(e => e.ArchiveDateTime).HasColumnType("datetime");
            entity.Property(e => e.ConsumedQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Designator)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FeederLocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaterialInstallDateTime).HasColumnType("datetime");
            entity.Property(e => e.MaterialSetupDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.MaterialContainer).WithMany(p => p.PartMaterialRecords)
                .HasForeignKey(d => d.MaterialContainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMaterialRecord_Container");

            entity.HasOne(d => d.MaterialSetupOperator).WithMany(p => p.PartMaterialRecords)
                .HasForeignKey(d => d.MaterialSetupOperatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMaterialRecord_User");

            entity.HasOne(d => d.MaterialSetupStation).WithMany(p => p.PartMaterialRecords)
                .HasForeignKey(d => d.MaterialSetupStationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMaterialRecord_Station");

            entity.HasOne(d => d.PartSerialNumber).WithMany(p => p.PartMaterialRecords)
                .HasForeignKey(d => d.PartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMaterialRecord_PartSerialNumber");

            entity.HasOne(d => d.ProcessStep).WithMany(p => p.PartMaterialRecords)
                .HasForeignKey(d => d.ProcessStepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMaterialRecord_ProcessStep");
        });

        modelBuilder.Entity<PartMaterialRecordHi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_trace.PartMaterialRecordHis");

            entity.ToTable("PartMaterialRecordHis", "trace");

            entity.Property(e => e.ArchiveDateTime).HasColumnType("datetime");
            entity.Property(e => e.ConsumedQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Designator)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FeederLocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaterialInstallDateTime).HasColumnType("datetime");
            entity.Property(e => e.MaterialSetupDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.MaterialSetupOperator).WithMany(p => p.PartMaterialRecordHis)
                .HasForeignKey(d => d.MaterialSetupOperatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMaterialRecordHis_User");

            entity.HasOne(d => d.MaterialSetupStation).WithMany(p => p.PartMaterialRecordHis)
                .HasForeignKey(d => d.MaterialSetupStationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMaterialRecordHis_Station");

            entity.HasOne(d => d.PartSerialNumber).WithMany(p => p.PartMaterialRecordHis)
                .HasForeignKey(d => d.PartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMaterialRecordHis_PartSerialNumber");

            entity.HasOne(d => d.ProcessStep).WithMany(p => p.PartMaterialRecordHis)
                .HasForeignKey(d => d.ProcessStepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMaterialRecordHis_ProcessStep");
        });

        modelBuilder.Entity<PartMeasurementDataRecord>(entity =>
        {
            entity.ToTable("PartMeasurementDataRecord", "trace");

            entity.Property(e => e.AVGValue).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ArchiveDateTime).HasColumnType("datetime");
            entity.Property(e => e.DataFileURI).HasColumnType("text");
            entity.Property(e => e.MAXValue).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MEANValue).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MINValue).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.PlainText).HasColumnType("text");
            entity.Property(e => e.ProfileValues).HasColumnType("text");
            entity.Property(e => e.RecipeItemId).HasComment("如果没有Recipe,Recipe,根据系统参数设定,可以报错, 也可以直接新建一个Recipe和RecipeItem");
            entity.Property(e => e.State).HasComment("0:OK,1:FAIL,2:SCRAP");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.PartProcessRecord).WithMany(p => p.PartMeasurementDataRecords)
                .HasForeignKey(d => d.PartProcessRecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMeasurementDataRecord_PartProcessRecord");

            entity.HasOne(d => d.RecipeItem).WithMany(p => p.PartMeasurementDataRecords)
                .HasForeignKey(d => d.RecipeItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMeasurementDataRecord_RecipeItem");
        });

        modelBuilder.Entity<PartMergeRecord>(entity =>
        {
            entity.ToTable("PartMergeRecord", "trace");

            entity.Property(e => e.MergeDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.MasterPartSerialNumber).WithMany(p => p.PartMergeRecordMasterPartSerialNumbers)
                .HasForeignKey(d => d.MasterPartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMergeRecord_PartSerialNumber");

            entity.HasOne(d => d.MergeStation).WithMany(p => p.PartMergeRecords)
                .HasForeignKey(d => d.MergeStationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMergeRecord_Station");

            entity.HasOne(d => d.Operator).WithMany(p => p.PartMergeRecords)
                .HasForeignKey(d => d.OperatorId)
                .HasConstraintName("FK_PartMergeRecord_User");

            entity.HasOne(d => d.SlavePartSerialNumber).WithMany(p => p.PartMergeRecordSlavePartSerialNumbers)
                .HasForeignKey(d => d.SlavePartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartMergeRecord_PartSerialNumber1");
        });

        modelBuilder.Entity<PartProcessOperationStepRecord>(entity =>
        {
            entity.ToTable("PartProcessOperationStepRecord", "trace");

            entity.HasOne(d => d.OperationStepldNavigation).WithMany(p => p.PartProcessOperationStepRecords)
                .HasForeignKey(d => d.OperationStepld)
                .HasConstraintName("FK_PartProcessOperationStepRecord_OperationStep");

            entity.HasOne(d => d.PartProcessRecord).WithMany(p => p.PartProcessOperationStepRecords)
                .HasForeignKey(d => d.PartProcessRecordId)
                .HasConstraintName("FK_PartProcessOperationStepRecord_PartProcessRecord");
        });

        modelBuilder.Entity<PartProcessRecord>(entity =>
        {
            entity.ToTable("PartProcessRecord", "trace");

            entity.Property(e => e.ArchiveDateTime).HasColumnType("datetime");
            entity.Property(e => e.BookDateTime).HasColumnType("datetime");
            entity.Property(e => e.CycleTime).HasDefaultValue(0.0);
            entity.Property(e => e.ProcessState).HasComment("-1:JustStartProduction, 0:Pass,1:Fail,2:Scrap");
            entity.Property(e => e.ProductionCompleteDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProductionDateTime).HasColumnType("datetime");
            entity.Property(e => e.UploadQuantity).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Operator).WithMany(p => p.PartProcessRecords)
                .HasForeignKey(d => d.OperatorId)
                .HasConstraintName("FK_PartProcessRecord_User");

            entity.HasOne(d => d.PartSerialNumber).WithMany(p => p.PartProcessRecords)
                .HasForeignKey(d => d.PartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartProcessRecord_PartSerialNumber");

            entity.HasOne(d => d.ProcessStep).WithMany(p => p.PartProcessRecords)
                .HasForeignKey(d => d.ProcessStepId)
                .HasConstraintName("FK_PartProcessRecord_ProcessStep");

            entity.HasOne(d => d.RepairStation).WithMany(p => p.PartProcessRecordRepairStations)
                .HasForeignKey(d => d.RepairStationId)
                .HasConstraintName("FK_PartProcessRecord_Station1");

            entity.HasOne(d => d.Station).WithMany(p => p.PartProcessRecordStations)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartProcessRecord_Station");
        });

        modelBuilder.Entity<PartRepairQualityCheckRecord>(entity =>
        {
            entity.ToTable("PartRepairQualityCheckRecord", "trace");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.PartRepairQualityCheckRecords)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartRepairQualityCheckRecord_User");

            entity.HasOne(d => d.PartRepairRecord).WithMany(p => p.InversePartRepairRecord)
                .HasForeignKey(d => d.PartRepairRecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartRepairQualityCheckRecord_PartRepairQualityCheckRecord");
        });

        modelBuilder.Entity<PartRepairRecord>(entity =>
        {
            entity.ToTable("PartRepairRecord", "trace");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.PartRepairRecords)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartRepairRecord_User");

            entity.HasOne(d => d.PartFailureDataRecord).WithMany(p => p.PartRepairRecords)
                .HasForeignKey(d => d.PartFailureDataRecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartRepairRecord_PartFailureDataRecord");

            entity.HasOne(d => d.RepairAction).WithMany(p => p.PartRepairRecords)
                .HasForeignKey(d => d.RepairActionId)
                .HasConstraintName("FK_PartRepairRecord_RepairAction");
        });

        modelBuilder.Entity<PartSerialNumber>(entity =>
        {
            entity.ToTable("PartSerialNumber", "core");

            entity.Property(e => e.Id).HasComment("0:Deactive,1:Active");
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.MasterSerialNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MaterialId).HasComment("当没有工单和BOM的时候用，别的时候不用");
            entity.Property(e => e.Position)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.State).HasComment("1:Active,0:Deactive,-1:QualityHold");

            entity.HasOne(d => d.Material).WithMany(p => p.PartSerialNumbers)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_PartSerialNumber_Material");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.PartSerialNumbers)
                .HasForeignKey(d => d.WorkOrderId)
                .HasConstraintName("FK_PartSerialNumber_WorkOrder");
        });

        modelBuilder.Entity<Platform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Adm_Platfrom");

            entity.ToTable("Platform", "core");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.PlatformName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Process>(entity =>
        {
            entity.ToTable("Process", "core");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProcessNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValidBegin).HasColumnType("datetime");
            entity.Property(e => e.ValidEnd).HasColumnType("datetime");

            entity.HasOne(d => d.Editor).WithMany(p => p.Processes)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Process_User");

            entity.HasOne(d => d.Factory).WithMany(p => p.Processes)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_Process_Factory");

            entity.HasOne(d => d.Material).WithMany(p => p.Processes)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Process_Materiel");
        });

        modelBuilder.Entity<ProcessStep>(entity =>
        {
            entity.ToTable("ProcessStep", "core");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.TimePerUnitInSeconds)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Process).WithMany(p => p.ProcessSteps)
                .HasForeignKey(d => d.ProcessId)
                .HasConstraintName("FK_ProcessSteps_Process");

            entity.HasOne(d => d.StationGroup).WithMany(p => p.ProcessSteps)
                .HasForeignKey(d => d.StationGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcessSteps_StationGroup");
        });

        modelBuilder.Entity<ProcurementType>(entity =>
        {
            entity.ToTable("ProcurementType", "core");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.ProcurementCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductDeliveryRequestForm>(entity =>
        {
            entity.ToTable("ProductDeliveryRequestForm", "wms");

            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Customer).WithMany(p => p.ProductDeliveryRequestForms)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ProductDeliveryRequestForm_Customer");

            entity.HasOne(d => d.Form).WithMany(p => p.ProductDeliveryRequestForms)
                .HasForeignKey(d => d.FormId)
                .HasConstraintName("FK_ProductDeliveryRequestForm_WMSForm");

            entity.HasOne(d => d.TargetArea).WithMany(p => p.ProductDeliveryRequestForms)
                .HasForeignKey(d => d.TargetAreaId)
                .HasConstraintName("FK_ProductDeliveryRequestForm_Area");
        });

        modelBuilder.Entity<ProductDeliveryRequestFormItem>(entity =>
        {
            entity.ToTable("ProductDeliveryRequestFormItem", "wms");

            entity.Property(e => e.PreparedQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RequestQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RequiredOnBoardDateTime).HasColumnType("datetime");
            entity.Property(e => e.RequiredShippingDateTime).HasColumnType("datetime");
            entity.Property(e => e.ScannedQuantity).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Material).WithMany(p => p.ProductDeliveryRequestFormItems)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_ProductDeliveryRequestFormItem_Material");

            entity.HasOne(d => d.ProductDeliveryRequestForm).WithMany(p => p.ProductDeliveryRequestFormItems)
                .HasForeignKey(d => d.ProductDeliveryRequestFormId)
                .HasConstraintName("FK_ProductDeliveryRequestFormItem_ProductDeliveryRequestForm");
        });

        modelBuilder.Entity<ProductInStockingForm>(entity =>
        {
            entity.ToTable("ProductInStockingForm", "wms");

            entity.HasOne(d => d.Form).WithMany(p => p.ProductInStockingForms)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductInStockingForm_WMSForm");
        });

        modelBuilder.Entity<ProductInStockingFormItem>(entity =>
        {
            entity.ToTable("ProductInStockingFormItem", "wms");

            entity.Property(e => e.RequestQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ScannedQuantity).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Material).WithMany(p => p.ProductInStockingFormItems)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_ProductInStockingFormItem_Material");

            entity.HasOne(d => d.ProductInStockForm).WithMany(p => p.ProductInStockingFormItems)
                .HasForeignKey(d => d.ProductInStockFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductInStockingFormItem_ProductInStockingForm");

            entity.HasOne(d => d.SourceLocation).WithMany(p => p.ProductInStockingFormItemSourceLocations)
                .HasForeignKey(d => d.SourceLocationId)
                .HasConstraintName("FK_ProductInStockingFormItem_Location");

            entity.HasOne(d => d.TargetLocation).WithMany(p => p.ProductInStockingFormItemTargetLocations)
                .HasForeignKey(d => d.TargetLocationId)
                .HasConstraintName("FK_ProductInStockingFormItem_Location1");

            entity.HasOne(d => d.Unit).WithMany(p => p.ProductInStockingFormItems)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_ProductInStockingFormItem_Unit");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.ProductInStockingFormItems)
                .HasForeignKey(d => d.WorkOrderId)
                .HasConstraintName("FK_ProductInStockingFormItem_WorkOrder");
        });

        modelBuilder.Entity<ProductModel>(entity =>
        {
            entity.ToTable("ProductModel", "core");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.ProductModelCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_TreeProduct_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.ProductModelEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_TreeProduct_User1");

            entity.HasOne(d => d.ProductModelNavigation).WithMany(p => p.ProductModels)
                .HasForeignKey(d => d.ProductModelId)
                .HasConstraintName("FK_TreeProduct_Material");
        });

        modelBuilder.Entity<ProductionPlan>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Producti__3214EC278C369401");

            entity.ToTable("ProductionPlan", "core");

            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Creator).WithMany(p => p.ProductionPlanCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_ProductionPlan_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.ProductionPlanEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_ProductionPlan_User1");

            entity.HasOne(d => d.Shift).WithMany(p => p.ProductionPlans)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("FK_ProductionPlan_Shift");
        });

        modelBuilder.Entity<ProductionPlanRecord>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Producti__3214EC27E79C3287");

            entity.ToTable("ProductionPlanRecord", "core");

            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.EventData).HasMaxLength(500);

            entity.HasOne(d => d.ProductionPlan).WithMany(p => p.ProductionPlanRecords)
                .HasForeignKey(d => d.ProductionPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionPlanRecord_ProductionPlan");
        });

        modelBuilder.Entity<QCStationDataX>(entity =>
        {
            entity.ToTable("QCStationDataX", "nbproj");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.DataName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DataValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direction).HasComment("1:PDA to QC, 2:QC to PDA");
            entity.Property(e => e.PDAId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDateTime)
                .HasComment("PLCOPCClientHandler处理时间")
                .HasColumnType("datetime");
            entity.Property(e => e.QCStationNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.State).HasComment("0: New, 2: Processed, -1: HasError");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QualityHoldForm>(entity =>
        {
            entity.ToTable("QualityHoldForm", "qms");

            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.FormNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoldType).HasComment("1:ContainerRegexHold,2:ContainerNumberHold,3:PartSerialNumberRegexHold,4:PartSerialNumberHold");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.State).HasComment("1:Active,0:Deactive,-1:Deleted");

            entity.HasOne(d => d.Creator).WithMany(p => p.QualityHoldFormCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_QualityHoldForm_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.QualityHoldFormEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_QualityHoldForm_User1");

            entity.HasOne(d => d.FutureHoldStationGroup).WithMany(p => p.QualityHoldForms)
                .HasForeignKey(d => d.FutureHoldStationGroupId)
                .HasConstraintName("FK_QualityHoldForm_StationGroup1");
        });

        modelBuilder.Entity<QualityHoldFormItem>(entity =>
        {
            entity.ToTable("QualityHoldFormItem", "qms");

            entity.Property(e => e.ObjectRegex)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.State).HasComment("1:Hold,2:Unhold,-1:Deleted");
            entity.Property(e => e.UnholdDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.QualityHoldForm).WithMany(p => p.QualityHoldFormItems)
                .HasForeignKey(d => d.QualityHoldFormId)
                .HasConstraintName("FK_QualityHoldFormItem_QualityHoldForm");

            entity.HasOne(d => d.UnholdEditor).WithMany(p => p.QualityHoldFormItems)
                .HasForeignKey(d => d.UnholdEditorId)
                .HasConstraintName("FK_QualityHoldFormItem_User");
        });

        modelBuilder.Entity<QualityUnHoldForm>(entity =>
        {
            entity.ToTable("QualityUnHoldForm", "qms");

            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.FormNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoldType).HasComment("1:ContainerRegexHold,2:ContainerNumberHold,3:PartSerialNumberRegexHold,4:PartSerialNumberHold");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.State).HasComment("1:Active,0:Deactive,-1:Deleted");

            entity.HasOne(d => d.Creator).WithMany(p => p.QualityUnHoldForms)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_QualityUnHoldForm_User");
        });

        modelBuilder.Entity<QualityUnHoldFormItem>(entity =>
        {
            entity.ToTable("QualityUnHoldFormItem", "qms");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.ObjectRegex)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.State).HasComment("1:Hold,2:Unhold,-1:Deleted");

            entity.HasOne(d => d.Creator).WithMany(p => p.QualityUnHoldFormItems)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_QualityUnHoldFormItem_User");

            entity.HasOne(d => d.QualityUnHoldForm).WithMany(p => p.QualityUnHoldFormItems)
                .HasForeignKey(d => d.QualityUnHoldFormId)
                .HasConstraintName("FK_QualityUnHoldFormItem_QualityUnHoldForm");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.ToTable("Recipe", "core");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.RecipeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Creator).WithMany(p => p.RecipeCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recipe_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.RecipeEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Recipe_User1");

            entity.HasOne(d => d.Machine).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.MachineId)
                .HasConstraintName("FK_Recipe_Machine");

            entity.HasOne(d => d.ProductType).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recipe_Material");

            entity.HasOne(d => d.Station).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.StationId)
                .HasConstraintName("FK_Recipe_Station");
        });

        modelBuilder.Entity<RecipeItem>(entity =>
        {
            entity.ToTable("RecipeItem", "core");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.JobCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LSL).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MatchString).HasMaxLength(50);
            entity.Property(e => e.ParameterName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParameterTypeId).HasComment("参数类型, 0:字符串匹配,1:显示Value,2:显示Profile,3:显示PlainText,4:显示文件的URI");
            entity.Property(e => e.StandardValue).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.State).HasComment("1:Enable,2:Disable");
            entity.Property(e => e.USL).HasColumnType("decimal(18, 3)");

            entity.HasOne(d => d.Creator).WithMany(p => p.RecipeItemCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipeItem_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.RecipeItemEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_RecipeItem_User1");

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipeItems)
                .HasForeignKey(d => d.RecipeId)
                .HasConstraintName("FK_RecipeItem_Recipe");
        });

        modelBuilder.Entity<RecipeItemRevisionRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RecipeItemRevisionRecord", "core");

            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.NewRecipeItem).WithMany()
                .HasForeignKey(d => d.NewRecipeItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipeItemRevisionRecord_RecipeItem1");

            entity.HasOne(d => d.OldRecipeItem).WithMany()
                .HasForeignKey(d => d.OldRecipeItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipeItemRevisionRecord_RecipeItem");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipeItemRevisionRecord_User");
        });

        modelBuilder.Entity<RepairAction>(entity =>
        {
            entity.ToTable("RepairAction", "core");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.RepairActionCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReplenishLocation_Station>(entity =>
        {
            entity.ToTable("ReplenishLocation_Station", "wms");

            entity.HasOne(d => d.ReplenishLocation).WithMany(p => p.ReplenishLocation_Stations)
                .HasForeignKey(d => d.ReplenishLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplenishLocation_Station_Location");

            entity.HasOne(d => d.Station).WithMany(p => p.ReplenishLocation_Stations)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReplenishLocation_Station_Station");
        });

        modelBuilder.Entity<ReworkRecord>(entity =>
        {
            entity.ToTable("ReworkRecord", "qms");

            entity.Property(e => e.CreationDateTime)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Creator).WithMany(p => p.ReworkRecords)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReworkRecord_User");

            entity.HasOne(d => d.FromProcessStep).WithMany(p => p.ReworkRecords)
                .HasForeignKey(d => d.FromProcessStepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReworkRecord_ProcessStep");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.ReworkRecords)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReworkRecord_WorkOrder");
        });

        modelBuilder.Entity<ReworkRecord_PartSerialNumber>(entity =>
        {
            entity.ToTable("ReworkRecord_PartSerialNumber", "qms");

            entity.HasOne(d => d.PartSerialNumber).WithMany(p => p.ReworkRecord_PartSerialNumbers)
                .HasForeignKey(d => d.PartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReworkRecord_PartSerialNumber_PartSerialNumber");

            entity.HasOne(d => d.ReworkRecord).WithMany(p => p.ReworkRecord_PartSerialNumbers)
                .HasForeignKey(d => d.ReworkRecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReworkRecord_PartSerialNumber_ReworkRecord");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Adm_Roles");

            entity.ToTable("Role", "core");

            entity.Property(e => e.AreaIdList).HasMaxLength(500);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Visit).HasMaxLength(500);

            entity.HasOne(d => d.Factory).WithMany(p => p.Roles)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_Role_Factory");

            entity.HasOne(d => d.Platform).WithMany(p => p.Roles)
                .HasForeignKey(d => d.PlatformId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Adm_Roles_Adm_Platfrom");
        });

        modelBuilder.Entity<RoleAuth>(entity =>
        {
            entity.ToTable("RoleAuth", "core");

            entity.Property(e => e.AuthValue).HasMaxLength(1000);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.RoleAuthCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleAuth_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.RoleAuthEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_RoleAuth_User1");

            entity.HasOne(d => d.Menu).WithMany(p => p.RoleAuths)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleAuth_Menu");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleAuths)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleAuth_Role");
        });

        modelBuilder.Entity<Role_Area>(entity =>
        {
            entity.ToTable("Role_Area", "core");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Area).WithMany(p => p.Role_Areas)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Role_Area_Area");

            entity.HasOne(d => d.Role).WithMany(p => p.Role_Areas)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Role_Area_Role");
        });

        modelBuilder.Entity<Roles_User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Adm_RolesAndUsersTheRelationship");

            entity.ToTable("Roles_Users", "core");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Role).WithMany(p => p.Roles_Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Adm_RolesAndUsersTheRelationship_Adm_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.Roles_Users)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Adm_RolesAndUsersTheRelationship_Adm_Users");
        });

        modelBuilder.Entity<SMTChangeOverTable>(entity =>
        {
            entity.ToTable("SMTChangeOverTable", "smt");

            entity.Property(e => e.ChangeOverTableCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CurrentMachineArea).WithMany(p => p.SMTChangeOverTables)
                .HasForeignKey(d => d.CurrentMachineAreaId)
                .HasConstraintName("FK_SMTChangeOverTable_SMTMachineArea");
        });

        modelBuilder.Entity<SMTChangeOverTableSetup>(entity =>
        {
            entity.ToTable("SMTChangeOverTableSetup", "smt");

            entity.Property(e => e.MaterialLocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SetupDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Container).WithMany(p => p.SMTChangeOverTableSetups)
                .HasForeignKey(d => d.ContainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTChangeOverTableSetup_Container1");

            entity.HasOne(d => d.Creator).WithMany(p => p.SMTChangeOverTableSetups)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_SMTChangeOverTableSetup_User");

            entity.HasOne(d => d.SMTChangeOverTable).WithMany(p => p.SMTChangeOverTableSetups)
                .HasForeignKey(d => d.SMTChangeOverTableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTChangeOverTableSetup_Container");
        });

        modelBuilder.Entity<SMTLine>(entity =>
        {
            entity.ToTable("SMTLine", "smt");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.LineCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SMTLine_SMTMachine>(entity =>
        {
            entity.ToTable("SMTLine_SMTMachine", "smt");

            entity.HasOne(d => d.SMTLine).WithMany(p => p.SMTLine_SMTMachines)
                .HasForeignKey(d => d.SMTLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTLine_SMTMachine_SMTLine");

            entity.HasOne(d => d.SMTMachine).WithMany(p => p.SMTLine_SMTMachines)
                .HasForeignKey(d => d.SMTMachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTLine_SMTMachine_SMTMachine");
        });

        modelBuilder.Entity<SMTMachine>(entity =>
        {
            entity.ToTable("SMTMachine", "smt");

            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.MachineCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.SMTMachines)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_SMTMachine_User");
        });

        modelBuilder.Entity<SMTMachineArea>(entity =>
        {
            entity.ToTable("SMTMachineArea", "smt");

            entity.Property(e => e.Name).HasMaxLength(20);

            entity.HasOne(d => d.Machine).WithMany(p => p.SMTMachineAreas)
                .HasForeignKey(d => d.MachineId)
                .HasConstraintName("FK_SMTMachineArea_SMTMachine");
        });

        modelBuilder.Entity<SMTOnlineProgram>(entity =>
        {
            entity.ToTable("SMTOnlineProgram", "smt");

            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Creator).WithMany(p => p.SMTOnlinePrograms)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_SMTProgramOnLine_User");

            entity.HasOne(d => d.Program).WithMany(p => p.SMTOnlinePrograms)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTProgramOnLine_SMTProgram");

            entity.HasOne(d => d.SMTLine).WithMany(p => p.SMTOnlinePrograms)
                .HasForeignKey(d => d.SMTLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTProgramOnLine_SMTLine");
        });

        modelBuilder.Entity<SMTOnlineSetup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SMTSetupOnLine");

            entity.ToTable("SMTOnlineSetup", "smt");

            entity.Property(e => e.MaterialLocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SetupDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Container).WithMany(p => p.SMTOnlineSetupContainers)
                .HasForeignKey(d => d.ContainerId)
                .HasConstraintName("FK_SMTOnlineSetup_Container");

            entity.HasOne(d => d.Creator).WithMany(p => p.SMTOnlineSetups)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_SMTOnlineSetup_User");

            entity.HasOne(d => d.NewContainer).WithMany(p => p.SMTOnlineSetupNewContainers)
                .HasForeignKey(d => d.NewContainerId)
                .HasConstraintName("FK_SMTOnlineSetup_Container1");

            entity.HasOne(d => d.SMTLine).WithMany(p => p.SMTOnlineSetups)
                .HasForeignKey(d => d.SMTLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTOnlineSetup_SMTLine");

            entity.HasOne(d => d.SMTMachineArea).WithMany(p => p.SMTOnlineSetups)
                .HasForeignKey(d => d.SMTMachineAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTOnlineSetup_SMTMachineArea");

            entity.HasOne(d => d.Setup).WithMany(p => p.SMTOnlineSetups)
                .HasForeignKey(d => d.SetupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTOnlineSetup_SMTSetup");
        });

        modelBuilder.Entity<SMTProgram>(entity =>
        {
            entity.ToTable("SMTProgram", "smt");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProgramCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Material).WithMany(p => p.SMTPrograms)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_SMTProgram_Material");

            entity.HasOne(d => d.SMTLine).WithMany(p => p.SMTPrograms)
                .HasForeignKey(d => d.SMTLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTProgram_SMTLine");

            entity.HasOne(d => d.Setup).WithMany(p => p.SMTPrograms)
                .HasForeignKey(d => d.SetupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTProgram_SMTSetup");
        });

        modelBuilder.Entity<SMTProgramDetail>(entity =>
        {
            entity.ToTable("SMTProgramDetail", "smt");

            entity.Property(e => e.Angel).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ComponentShapeCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Designator)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaterialLocation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.XPosition).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.YPosition).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Material).WithMany(p => p.SMTProgramDetails)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTProgramDetail_Material");

            entity.HasOne(d => d.SMTMachineArea).WithMany(p => p.SMTProgramDetails)
                .HasForeignKey(d => d.SMTMachineAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTProgramDetail_SMTMachineArea");

            entity.HasOne(d => d.SMTProgram).WithMany(p => p.SMTProgramDetails)
                .HasForeignKey(d => d.SMTProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTProgramDetail_SMTProgram");
        });

        modelBuilder.Entity<SMTSetup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Setup");

            entity.ToTable("SMTSetup", "smt");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.SetupName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.SMTSetupCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Setup_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.SMTSetupEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Setup_User1");
        });

        modelBuilder.Entity<SMTSetupListItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SetupListItem");

            entity.ToTable("SMTSetupListItem", "smt");

            entity.Property(e => e.MaterialLocation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MachineArea).WithMany(p => p.SMTSetupListItems)
                .HasForeignKey(d => d.MachineAreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTSetupListItem_SMTMachineArea");

            entity.HasOne(d => d.Material).WithMany(p => p.SMTSetupListItems)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTSetupListItem_Material");

            entity.HasOne(d => d.Setup).WithMany(p => p.SMTSetupListItems)
                .HasForeignKey(d => d.SetupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMTSetupListItem_SMTSetup");
        });

        modelBuilder.Entity<SNCounter>(entity =>
        {
            entity.ToTable("SNCounter", "ProjAppleTrace", tb => tb.HasComment("序列号计数器"));

            entity.Property(e => e.MaterialNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeId).HasComment("1:Raw Material Container SN, 2: Part SN, 3:Virtual Final Product SN,4:Customer SN");
            entity.Property(e => e.WorkOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SerialNumberRegex>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StampSNRegex");

            entity.ToTable("SerialNumberRegex", "core");

            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProductFamily).HasMaxLength(100);
            entity.Property(e => e.RegexExpression)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Editor).WithMany(p => p.SerialNumberRegexes)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_StampSNRegex_User");

            entity.HasOne(d => d.ProductMaterial).WithMany(p => p.SerialNumberRegexes)
                .HasForeignKey(d => d.ProductMaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StampSNRegex_Material");
        });

        modelBuilder.Entity<SerialNumberSwitchRecord>(entity =>
        {
            entity.ToTable("SerialNumberSwitchRecord", "trace");

            entity.Property(e => e.NewSerialNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OldSerialNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SwitchDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Editor).WithMany(p => p.SerialNumberSwitchRecords)
                .HasForeignKey(d => d.EditorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SerialNumberSwitchRecord_User");

            entity.HasOne(d => d.PartSerialNumber).WithMany(p => p.SerialNumberSwitchRecords)
                .HasForeignKey(d => d.PartSerialNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SerialNumberSwitchRecord_PartSerialNumber");
        });

        modelBuilder.Entity<SetupRecord>(entity =>
        {
            entity.ToTable("SetupRecord", "trace");

            entity.Property(e => e.BatchNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("批次号");
            entity.Property(e => e.ContainerId).HasComment("ContainerId");
            entity.Property(e => e.Designator)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("某个总成中的某个BOMItem的唯一Designator物料位置号");
            entity.Property(e => e.Device)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("可以填入PDA的序列号，用来找到某个设备扫码的");
            entity.Property(e => e.Feeder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("某个设备的某个供料器代号");
            entity.Property(e => e.OperatorId).HasComment("上料员工Id");
            entity.Property(e => e.Quantity)
                .HasComment("数量")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ScannedContent)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("扫描到的内容");
            entity.Property(e => e.SetupDateTime)
                .HasComment("上料，下料，接料时间")
                .HasColumnType("datetime");
            entity.Property(e => e.SetupResult).HasComment("1：成功，2：失败");
            entity.Property(e => e.SetupType).HasComment("上料类型：1：上料，2：下料，3：接料");

            entity.HasOne(d => d.Container).WithMany(p => p.SetupRecords)
                .HasForeignKey(d => d.ContainerId)
                .HasConstraintName("FK_SetupRecord_Container");

            entity.HasOne(d => d.Operator).WithMany(p => p.SetupRecords)
                .HasForeignKey(d => d.OperatorId)
                .HasConstraintName("FK_SetupRecord_User");

            entity.HasOne(d => d.Station).WithMany(p => p.SetupRecords)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SetupRecord_Station");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.ToTable("Shift", "core");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.ToTable("Skill", "core");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Level)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<SolderPaste>(entity =>
        {
            entity.ToTable("SolderPaste", "sp");
        });

        modelBuilder.Entity<SolderPasteEventHistory>(entity =>
        {
            entity.ToTable("SolderPasteEventHistory", "sp");

            entity.Property(e => e.EventDateTime).HasColumnType("datetime");
            entity.Property(e => e.EventTypeId).HasComment("锡膏事件类型:0:收货,1:注册到冰箱,2:注册到回温区,3:注册到机台");

            entity.HasOne(d => d.Location).WithMany(p => p.SolderPasteEventHistories)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SolderPasteEventHistory_Location");

            entity.HasOne(d => d.Operator).WithMany(p => p.SolderPasteEventHistories)
                .HasForeignKey(d => d.OperatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SolderPasteEventHistory_User");
        });

        modelBuilder.Entity<SolderPrintingMachineRecipe>(entity =>
        {
            entity.ToTable("SolderPrintingMachineRecipe", "sp");

            entity.Property(e => e.RecipeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SolderPrintingSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SolderPasteType");

            entity.ToTable("SolderPrintingSetting", "sp");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.ParameterCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ValueType)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.SolderPrintingSettingCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SolderPrintingSetting_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.SolderPrintingSettingEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_SolderPrintingSetting_User1");
        });

        modelBuilder.Entity<Squeege>(entity =>
        {
            entity.ToTable("Squeege", "sp", tb => tb.HasComment("刮刀"));

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.SqueegeType).WithMany(p => p.Squeeges)
                .HasForeignKey(d => d.SqueegeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Squeege_SqueegeType");
        });

        modelBuilder.Entity<SqueegeEventHistory>(entity =>
        {
            entity.ToTable("SqueegeEventHistory", "sp");

            entity.Property(e => e.EventDateTime).HasColumnType("datetime");
            entity.Property(e => e.EventTypeId).HasComment("事件类型0:新注册,1:注册至机台,2:注册至清洗台");

            entity.HasOne(d => d.Location).WithMany(p => p.SqueegeEventHistories)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SqueegeEventHistory_Location");

            entity.HasOne(d => d.Operator).WithMany(p => p.SqueegeEventHistories)
                .HasForeignKey(d => d.OperatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SqueegeEventHistory_User");

            entity.HasOne(d => d.Squeege).WithMany(p => p.SqueegeEventHistories)
                .HasForeignKey(d => d.SqueegeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SqueegeEventHistory_Squeege");
        });

        modelBuilder.Entity<SqueegeType>(entity =>
        {
            entity.ToTable("SqueegeType", "sp");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Station>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Equipment");

            entity.ToTable("Station", "core");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.State).HasComment("1:Active,0:Deactive");
            entity.Property(e => e.StationNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StationType).HasComment("1:Production Station, 2:Test Station, 3: Repair Station, 4:Virtual Station");

            entity.HasOne(d => d.Creator).WithMany(p => p.StationCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Station_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.StationEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Station_User1");

            entity.HasOne(d => d.Factory).WithMany(p => p.Stations)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_Station_Factory");
        });

        modelBuilder.Entity<StationCurrentStatus>(entity =>
        {
            entity.HasKey(e => e.StationId);

            entity.ToTable("StationCurrentStatus", "pms");

            entity.Property(e => e.StationId).ValueGeneratedNever();
            entity.Property(e => e.CycleTime).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<StationFailure>(entity =>
        {
            entity.ToTable("StationFailure", "pms");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<StationGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EquipmentGroup");

            entity.ToTable("StationGroup", "core");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.GroupNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Editor).WithMany(p => p.StationGroups)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_StationGroup_User");

            entity.HasOne(d => d.Factory).WithMany(p => p.StationGroups)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_StationGroup_Factory");
        });

        modelBuilder.Entity<StationParameter>(entity =>
        {
            entity.ToTable("StationParameter", "core");

            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.ParameterValue).HasMaxLength(2000);

            entity.HasOne(d => d.Editor).WithMany(p => p.StationParameters)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_StationParameter_User");

            entity.HasOne(d => d.MESParameterReference).WithMany(p => p.StationParameters)
                .HasForeignKey(d => d.MESParameterReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StationParameter_MESParameterReference");

            entity.HasOne(d => d.Station).WithMany(p => p.StationParameters)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StationParameter_Station");
        });

        modelBuilder.Entity<StationStatusHi>(entity =>
        {
            entity.ToTable("StationStatusHis", "pms");

            entity.Property(e => e.BookDateTime).HasColumnType("datetime");
            entity.Property(e => e.EventDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Station_Printer>(entity =>
        {
            entity.ToTable("Station_Printer", "core");

            entity.Property(e => e.PrintName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Station).WithMany(p => p.Station_Printers)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Station_Printer_Station");
        });

        modelBuilder.Entity<Station_StationGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EquipmentRelationTab");

            entity.ToTable("Station_StationGroup", "core");

            entity.Property(e => e.EditDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Editor).WithMany(p => p.Station_StationGroups)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Station_StationGroup_User");

            entity.HasOne(d => d.StationGroup).WithMany(p => p.Station_StationGroups)
                .HasForeignKey(d => d.StationGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Station_StationGroup_StationGroup");

            entity.HasOne(d => d.Station).WithMany(p => p.Station_StationGroups)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Station_StationGroup_Station");
        });

        modelBuilder.Entity<Stations_Skill>(entity =>
        {
            entity.ToTable("Stations_Skill", "core");

            entity.Property(e => e.Type).HasComment("1:StationGroup,2:Station");

            entity.HasOne(d => d.Skill).WithMany(p => p.Stations_Skills)
                .HasForeignKey(d => d.SkillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stations_Skill_Skill");

            entity.HasOne(d => d.StationGroup).WithMany(p => p.Stations_Skills)
                .HasForeignKey(d => d.StationGroupId)
                .HasConstraintName("FK_Stations_Skill_StationGroup");

            entity.HasOne(d => d.Station).WithMany(p => p.Stations_Skills)
                .HasForeignKey(d => d.StationId)
                .HasConstraintName("FK_Stations_Skill_Station");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("Supplier", "core");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.ContactPerson).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.DUNS)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PostCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.SupplierCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telphone)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.SupplierCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_Supplier_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.SupplierEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Supplier_User1");
        });

        modelBuilder.Entity<TPMMaterialRecord>(entity =>
        {
            entity.ToTable("TPMMaterialRecord", "tpm");

            entity.HasOne(d => d.MaterialContainer).WithMany(p => p.TPMMaterialRecords)
                .HasForeignKey(d => d.MaterialContainerId)
                .HasConstraintName("FK_TPMMaterialRecord_Container");

            entity.HasOne(d => d.NewMaterial).WithMany(p => p.TPMMaterialRecords)
                .HasForeignKey(d => d.NewMaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMMaterialRecord_Material");

            entity.HasOne(d => d.TPMWorkRecord).WithMany(p => p.TPMMaterialRecords)
                .HasForeignKey(d => d.TPMWorkRecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMMaterialRecord_TPMWorkRecord");
        });

        modelBuilder.Entity<TPMReminder>(entity =>
        {
            entity.ToTable("TPMReminder", "tpm");

            entity.Property(e => e.CORNExpression)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Creator).WithMany(p => p.TPMReminderCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMReminder_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.TPMReminderEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_TPMReminder_User1");

            entity.HasOne(d => d.TPMWorkPlan).WithMany(p => p.TPMReminders)
                .HasForeignKey(d => d.TPMWorkPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMReminder_TPMWorkPlan");
        });

        modelBuilder.Entity<TPMWorkOrder>(entity =>
        {
            entity.ToTable("TPMWorkOrder", "tpm");

            entity.Property(e => e.ActualFinishDateTime).HasColumnType("datetime");
            entity.Property(e => e.ActualStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.Code)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.DueDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.PlanFinishDateTime).HasColumnType("datetime");
            entity.Property(e => e.PlanStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.Status).HasComment("进度, 10: Created, 20 :Started, 30:Canceled,, 40:Pending, 100:Completed");

            entity.HasOne(d => d.Creator).WithMany(p => p.TPMWorkOrderCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK_TPMWorkOrder_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.TPMWorkOrderEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_TPMWorkOrder_User1");
        });

        modelBuilder.Entity<TPMWorkOrderItem>(entity =>
        {
            entity.ToTable("TPMWorkOrderItem", "tpm");

            entity.Property(e => e.Designator).HasMaxLength(50);

            entity.HasOne(d => d.ActionOwer).WithMany(p => p.TPMWorkOrderItems)
                .HasForeignKey(d => d.ActionOwerId)
                .HasConstraintName("FK_TPMWorkOrderItem_User");

            entity.HasOne(d => d.DefaultMaintenanceRole).WithMany(p => p.TPMWorkOrderItems)
                .HasForeignKey(d => d.DefaultMaintenanceRoleId)
                .HasConstraintName("FK_TPMWorkOrderItem_Role");

            entity.HasOne(d => d.Edocument).WithMany(p => p.TPMWorkOrderItems)
                .HasForeignKey(d => d.EdocumentId)
                .HasConstraintName("FK_TPMWorkOrderItem_EDocument");

            entity.HasOne(d => d.MaintenanceItem).WithMany(p => p.TPMWorkOrderItems)
                .HasForeignKey(d => d.MaintenanceItemId)
                .HasConstraintName("FK_TPMWorkOrderItem_MaintenanceItem");

            entity.HasOne(d => d.Material).WithMany(p => p.TPMWorkOrderItems)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_TPMWorkOrderItem_Material");

            entity.HasOne(d => d.TPMWorkOrder).WithMany(p => p.TPMWorkOrderItems)
                .HasForeignKey(d => d.TPMWorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMWorkOrderItem_TPMWorkOrder");
        });

        modelBuilder.Entity<TPMWorkOrderItemTransferRecord>(entity =>
        {
            entity.ToTable("TPMWorkOrderItemTransferRecord", "tpm");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.FromOwner).WithMany(p => p.TPMWorkOrderItemTransferRecordFromOwners)
                .HasForeignKey(d => d.FromOwnerId)
                .HasConstraintName("FK_TPMWorkOrderItemTransferRecord_User1");

            entity.HasOne(d => d.Initiator).WithMany(p => p.TPMWorkOrderItemTransferRecordInitiators)
                .HasForeignKey(d => d.InitiatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMWorkOrderItemTransferRecord_User");

            entity.HasOne(d => d.TPMWorOrderItem).WithMany(p => p.TPMWorkOrderItemTransferRecords)
                .HasForeignKey(d => d.TPMWorOrderItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMWorkOrderItemTransferRecord_TPMWorkOrderItem");

            entity.HasOne(d => d.ToOwner).WithMany(p => p.TPMWorkOrderItemTransferRecordToOwners)
                .HasForeignKey(d => d.ToOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMWorkOrderItemTransferRecord_User2");
        });

        modelBuilder.Entity<TPMWorkOrder_TPMWorkPlan>(entity =>
        {
            entity.ToTable("TPMWorkOrder_TPMWorkPlan", "tpm");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.TPMWorkOrder).WithMany(p => p.TPMWorkOrder_TPMWorkPlans)
                .HasForeignKey(d => d.TPMWorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMWorkOrder_TPMWorkPlan_TPMWorkOrder");

            entity.HasOne(d => d.TPMWorkPlan).WithMany(p => p.TPMWorkOrder_TPMWorkPlans)
                .HasForeignKey(d => d.TPMWorkPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMWorkOrder_TPMWorkPlan_TPMWorkPlan");
        });

        modelBuilder.Entity<TPMWorkPlan>(entity =>
        {
            entity.ToTable("TPMWorkPlan", "tpm");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Creator).WithMany(p => p.TPMWorkPlanCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMWorkPlan_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.TPMWorkPlanEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_TPMWorkPlan_User1");

            entity.HasOne(d => d.Machine).WithMany(p => p.TPMWorkPlans)
                .HasForeignKey(d => d.MachineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMWorkPlan_Machine");
        });

        modelBuilder.Entity<TPMWorkPlanItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TPMWorkItem");

            entity.ToTable("TPMWorkPlanItem", "tpm");

            entity.Property(e => e.Designator).HasMaxLength(50);
            entity.Property(e => e.IsMandatory).HasComment("1:Mandatory,2:Optional");
            entity.Property(e => e.MeasurementType).HasComment("1:ValueRange,2:SpecificNormalValue,3:ProfileData");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.RequireMeasure).HasComment("1:Required,0:NoNeed");

            entity.HasOne(d => d.DefaultMaintenanceRole).WithMany(p => p.TPMWorkPlanItems)
                .HasForeignKey(d => d.DefaultMaintenanceRoleId)
                .HasConstraintName("FK_TPMWorkItem_Role");

            entity.HasOne(d => d.Edocument).WithMany(p => p.TPMWorkPlanItems)
                .HasForeignKey(d => d.EdocumentId)
                .HasConstraintName("FK_TPMWorkItem_EDocument");

            entity.HasOne(d => d.MaintenanceItem).WithMany(p => p.TPMWorkPlanItems)
                .HasForeignKey(d => d.MaintenanceItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMWorkItem_MaintenanceItem");

            entity.HasOne(d => d.Material).WithMany(p => p.TPMWorkPlanItems)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_TPMWorkItem_Material");

            entity.HasOne(d => d.TPMWorkPlan).WithMany(p => p.TPMWorkPlanItems)
                .HasForeignKey(d => d.TPMWorkPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMWorkItem_TPMWorkPlan");

            entity.HasOne(d => d.Unit).WithMany(p => p.TPMWorkPlanItems)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_TPMWorkItem_Unit");
        });

        modelBuilder.Entity<TPMWorkRecord>(entity =>
        {
            entity.ToTable("TPMWorkRecord", "tpm");

            entity.Property(e => e.AfterPicture1).HasMaxLength(255);
            entity.Property(e => e.AfterPicture2).HasMaxLength(255);
            entity.Property(e => e.AfterPicture3).HasMaxLength(255);
            entity.Property(e => e.AfterProfileData).IsUnicode(false);
            entity.Property(e => e.BeforePicture1).HasMaxLength(255);
            entity.Property(e => e.BeforePicture2).HasMaxLength(255);
            entity.Property(e => e.BeforePicture3).HasMaxLength(255);
            entity.Property(e => e.BeforeProfileData).IsUnicode(false);
            entity.Property(e => e.FinishDateTime).HasColumnType("datetime");
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.TPMWorkOrderItem).WithMany(p => p.TPMWorkRecords)
                .HasForeignKey(d => d.TPMWorkOrderItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPMWorkRecord_TPMWorkOrderItem");
        });

        modelBuilder.Entity<Tooling>(entity =>
        {
            entity.ToTable("Tooling", "core", tb => tb.HasComment("工装夹具"));

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ToolingCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.ToolingCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tooling_User");

            entity.HasOne(d => d.CurrentLocation).WithMany(p => p.Toolings)
                .HasForeignKey(d => d.CurrentLocationId)
                .HasConstraintName("FK_Tooling_Location");

            entity.HasOne(d => d.Editor).WithMany(p => p.ToolingEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_Tooling_User1");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Toolings)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Tooling_Supplier");

            entity.HasOne(d => d.ToolingType).WithMany(p => p.Toolings)
                .HasForeignKey(d => d.ToolingTypeId)
                .HasConstraintName("FK_Tooling_ToolingType");
        });

        modelBuilder.Entity<ToolingLife>(entity =>
        {
            entity.ToTable("ToolingLife", "core");

            entity.Property(e => e.CurrentLifeConsumedValue).HasColumnType("decimal(18, 3)");

            entity.HasOne(d => d.Tooling).WithMany(p => p.ToolingLives)
                .HasForeignKey(d => d.ToolingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolingLife_Tooling");

            entity.HasOne(d => d.ToolingLifeCheckRule).WithMany(p => p.ToolingLives)
                .HasForeignKey(d => d.ToolingLifeCheckRuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolingLife_ToolingLifeCheckRule");
        });

        modelBuilder.Entity<ToolingLifeCheckRule>(entity =>
        {
            entity.ToTable("ToolingLifeCheckRule", "core");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExpirationLifeThreshold).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.RuleCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WarningLifeThreshold).HasColumnType("decimal(18, 3)");

            entity.HasOne(d => d.Creator).WithMany(p => p.ToolingLifeCheckRuleCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolingLifeCheckRule_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.ToolingLifeCheckRuleEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_ToolingLifeCheckRule_User1");

            entity.HasOne(d => d.LifeCalculationTypeUnit).WithMany(p => p.ToolingLifeCheckRules)
                .HasForeignKey(d => d.LifeCalculationTypeUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolingLifeCheckRule_Unit");
        });

        modelBuilder.Entity<ToolingType>(entity =>
        {
            entity.ToTable("ToolingType", "core", tb => tb.HasComment("工装类型"));

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Specification).HasMaxLength(50);

            entity.HasOne(d => d.Creator).WithMany(p => p.ToolingTypeCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolingType_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.ToolingTypeEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_ToolingType_User1");

            entity.HasOne(d => d.Material).WithMany(p => p.ToolingTypes)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_ToolingType_Material");
        });

        modelBuilder.Entity<ToolingType_ToolingLifeCheckRule>(entity =>
        {
            entity.ToTable("ToolingType_ToolingLifeCheckRule", "core");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.State).HasComment("0:Deactive,1:Active");

            entity.HasOne(d => d.ToolingLifeCheckRule).WithMany(p => p.ToolingType_ToolingLifeCheckRules)
                .HasForeignKey(d => d.ToolingLifeCheckRuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolingType_ToolingLifeCheckRule_ToolingLifeCheckRule");

            entity.HasOne(d => d.ToolingType).WithMany(p => p.ToolingType_ToolingLifeCheckRules)
                .HasForeignKey(d => d.ToolingTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolingType_ToolingLifeCheckRule_ToolingType");
        });

        modelBuilder.Entity<UPH>(entity =>
        {
            entity.ToTable("UPH", "core");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.State).HasComment("1:Active, 0:Deactive");
            entity.Property(e => e.value).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Cell).WithMany(p => p.UPHs)
                .HasForeignKey(d => d.CellId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UPH_Cell");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.ToTable("Unit", "core");

            entity.Property(e => e.Name).HasMaxLength(5);
            entity.Property(e => e.UnitCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Users");

            entity.ToTable("User", "core");

            entity.Property(e => e.Account)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HeadIcon).HasMaxLength(200);
            entity.Property(e => e.LastLoginTime).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Factory).WithMany(p => p.Users)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_User_Factory");

            entity.HasOne(d => d.Platform).WithMany(p => p.Users)
                .HasForeignKey(d => d.PlatformId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Adm_Users_Adm_Platfrom");
        });

        modelBuilder.Entity<UserFingerprint>(entity =>
        {
            entity.ToTable("UserFingerprint", "core");

            entity.Property(e => e.CreateTime).HasColumnType("datetime");
            entity.Property(e => e.DeviceCode).HasMaxLength(50);
            entity.Property(e => e.FingerprintTemplate1).HasColumnType("image");
            entity.Property(e => e.FingerprintTemplate2).HasColumnType("image");
            entity.Property(e => e.FingerprintTemplate3).HasColumnType("image");
            entity.Property(e => e.FingerprintTemplate4).HasColumnType("image");
            entity.Property(e => e.FingerprintTemplate5).HasColumnType("image");

            entity.HasOne(d => d.User).WithMany(p => p.UserFingerprints)
                .HasForeignKey(d => d.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserFingerprint_User");
        });

        modelBuilder.Entity<WMSForm>(entity =>
        {
            entity.ToTable("WMSForm", "wms");

            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.FormNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Creator).WithMany(p => p.WMSFormCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WMSForm_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.WMSFormEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_WMSForm_User1");

            entity.HasOne(d => d.FormType).WithMany(p => p.WMSForms)
                .HasForeignKey(d => d.FormTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WMSForm_FormType");
        });

        modelBuilder.Entity<WMSWorkOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WorkOrder");

            entity.ToTable("WMSWorkOrder", "wms");

            entity.Property(e => e.ActualBuiltQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ActualFinishedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ActualStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.PlannedFinishDateTime).HasColumnType("datetime");
            entity.Property(e => e.PlannedQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PlannedStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.WorkOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Cell).WithMany(p => p.WMSWorkOrders)
                .HasForeignKey(d => d.CellId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrder_Cell");

            entity.HasOne(d => d.Location).WithMany(p => p.WMSWorkOrders)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrder_Location");

            entity.HasOne(d => d.Material).WithMany(p => p.WMSWorkOrders)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrder_Material");

            entity.HasOne(d => d.Unit).WithMany(p => p.WMSWorkOrders)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrder_Unit");
        });

        modelBuilder.Entity<WMS_ManufacturingMaterialReturnRecord>(entity =>
        {
            entity.ToTable("WMS_ManufacturingMaterialReturnRecord", "xapi");

            entity.Property(e => e.BatchNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContainerNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.CreatorCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReturnFromLocationCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReturnFrommAreaCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReturnQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ReturnToAreaCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReturnToLocationCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Stamp).HasColumnType("datetime");
            entity.Property(e => e.UnitCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkOrderCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WMS_WorkOrderBackflushRecord>(entity =>
        {
            entity.ToTable("WMS_WorkOrderBackflushRecord", "xapi");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BackflushDateTime).HasColumnType("datetime");
            entity.Property(e => e.BatchNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.LineCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReportQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Stamp).HasColumnType("datetime");
            entity.Property(e => e.UnitCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkOrderCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WorkOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WorkOrder_1");

            entity.ToTable("WorkOrder", "core");

            entity.Property(e => e.ActualBuiltQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ActualFinishedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ActualInputQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ActualStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.Comment)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateTime).HasColumnType("datetime");
            entity.Property(e => e.EditDateTime).HasColumnType("datetime");
            entity.Property(e => e.PlannedFinishDateTime).HasColumnType("datetime");
            entity.Property(e => e.PlannedQuantity).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PlannedStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.State).HasComment("0:Planned/New,10:Started,100:Completed,99:Closed");
            entity.Property(e => e.Type).HasComment("0:normal,1:virtual");
            entity.Property(e => e.WorkOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.BOMHead).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.BOMHeadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrder_BOMHead");

            entity.HasOne(d => d.Creator).WithMany(p => p.WorkOrderCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrder_User");

            entity.HasOne(d => d.Editor).WithMany(p => p.WorkOrderEditors)
                .HasForeignKey(d => d.EditorId)
                .HasConstraintName("FK_WorkOrder_User1");

            entity.HasOne(d => d.Factory).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.FactoryId)
                .HasConstraintName("FK_WorkOrder_Factory");

            entity.HasOne(d => d.Line).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.LineId)
                .HasConstraintName("FK_WorkOrder_Line");

            entity.HasOne(d => d.Process).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.ProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrder_Process");

            entity.HasOne(d => d.Shift).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("FK_WorkOrder_Shift");

            entity.HasOne(d => d.Unit).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrder_Unit");
        });

        modelBuilder.Entity<WorkOrderMaterialRecord>(entity =>
        {
            entity.ToTable("WorkOrderMaterialRecord", "trace");

            entity.Property(e => e.Quantity)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SetupDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Container).WithMany(p => p.WorkOrderMaterialRecords)
                .HasForeignKey(d => d.ContainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderMaterialRecord_Container");

            entity.HasOne(d => d.Operator).WithMany(p => p.WorkOrderMaterialRecords)
                .HasForeignKey(d => d.OperatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderMaterialRecord_User");

            entity.HasOne(d => d.Unit).WithMany(p => p.WorkOrderMaterialRecords)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK_WorkOrderMaterialRecord_Unit");

            entity.HasOne(d => d.WorkOrderProcessRecord).WithMany(p => p.WorkOrderMaterialRecords)
                .HasForeignKey(d => d.WorkOrderProcessRecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderMaterialRecord_WorkOrderProcessRecord");
        });

        modelBuilder.Entity<WorkOrderProcessRecord>(entity =>
        {
            entity.ToTable("WorkOrderProcessRecord", "trace");

            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.GoodQuantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NGQuantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            entity.Property(e => e.State).HasComment("10:Start work, 20: Report work");
            entity.Property(e => e.Status).HasComment("预留以后用");

            entity.HasOne(d => d.Operator).WithMany(p => p.WorkOrderProcessRecords)
                .HasForeignKey(d => d.OperatorId)
                .HasConstraintName("FK_WorkOrderProcessRecord_User");

            entity.HasOne(d => d.ProcessStep).WithMany(p => p.WorkOrderProcessRecords)
                .HasForeignKey(d => d.ProcessStepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderProcessRecord_ProcessStep");

            entity.HasOne(d => d.Station).WithMany(p => p.WorkOrderProcessRecords)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderProcessRecord_Station");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrderProcessRecords)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderProcessRecord_WorkOrder");
        });

        modelBuilder.Entity<WorkOrderQualityRecord>(entity =>
        {
            entity.ToTable("WorkOrderQualityRecord", "trace");

            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.FailQuantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RecordDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.FailureCause).WithMany(p => p.WorkOrderQualityRecords)
                .HasForeignKey(d => d.FailureCauseId)
                .HasConstraintName("FK_WorkOrderQualityRecord_FailureCause");

            entity.HasOne(d => d.FailureType).WithMany(p => p.WorkOrderQualityRecords)
                .HasForeignKey(d => d.FailureTypeId)
                .HasConstraintName("FK_WorkOrderQualityRecord_FailureType");

            entity.HasOne(d => d.Operator).WithMany(p => p.WorkOrderQualityRecords)
                .HasForeignKey(d => d.OperatorId)
                .HasConstraintName("FK_WorkOrderQualityRecord_User");

            entity.HasOne(d => d.WorkOrderProcessRecord).WithMany(p => p.WorkOrderQualityRecords)
                .HasForeignKey(d => d.WorkOrderProcessRecordId)
                .HasConstraintName("FK_WorkOrderQualityRecord_WorkOrderProcessRecord");
        });

        modelBuilder.Entity<WorkOrder_Cell>(entity =>
        {
            entity.ToTable("WorkOrder_Cell", "core");

            entity.HasOne(d => d.Cell).WithMany(p => p.WorkOrder_Cells)
                .HasForeignKey(d => d.CellId)
                .HasConstraintName("FK_WorkOrder_Cell_Cell");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrder_Cells)
                .HasForeignKey(d => d.WorkOrderId)
                .HasConstraintName("FK_WorkOrder_Cell_WorkOrder_Cell");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
