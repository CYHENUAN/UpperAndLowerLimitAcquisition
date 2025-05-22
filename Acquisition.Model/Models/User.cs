using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int PlatformId { get; set; }

    public string? EmailAddress { get; set; }

    public string? Phone { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int State { get; set; }

    public DateTime? LastLoginTime { get; set; }

    public string Account { get; set; } = null!;

    public string? UserCode { get; set; }

    public int? FactoryId { get; set; }

    public string? HeadIcon { get; set; }

    public virtual ICollection<Area> AreaCreators { get; set; } = new List<Area>();

    public virtual ICollection<Area> AreaEditors { get; set; } = new List<Area>();

    public virtual ICollection<AttributeDataRecord> AttributeDataRecords { get; set; } = new List<AttributeDataRecord>();

    public virtual ICollection<AttributeType> AttributeTypeCreators { get; set; } = new List<AttributeType>();

    public virtual ICollection<AttributeType> AttributeTypeEditors { get; set; } = new List<AttributeType>();

    public virtual ICollection<BOMHead> BOMHeadCreators { get; set; } = new List<BOMHead>();

    public virtual ICollection<BOMHead> BOMHeadEditors { get; set; } = new List<BOMHead>();

    public virtual ICollection<CarrierBindRecord> CarrierBindRecords { get; set; } = new List<CarrierBindRecord>();

    public virtual ICollection<Carrier> CarrierCreators { get; set; } = new List<Carrier>();

    public virtual ICollection<Carrier> CarrierEditors { get; set; } = new List<Carrier>();

    public virtual ICollection<Cell> CellCreators { get; set; } = new List<Cell>();

    public virtual ICollection<Cell> CellEditors { get; set; } = new List<Cell>();

    public virtual ICollection<Cell_Station> Cell_Stations { get; set; } = new List<Cell_Station>();

    public virtual ICollection<Certification_User> Certification_UserCreators { get; set; } = new List<Certification_User>();

    public virtual ICollection<Certification_User> Certification_UserUsers { get; set; } = new List<Certification_User>();

    public virtual ICollection<Company> CompanyCreators { get; set; } = new List<Company>();

    public virtual ICollection<Company> CompanyEditors { get; set; } = new List<Company>();

    public virtual ICollection<CompanyParameter> CompanyParameters { get; set; } = new List<CompanyParameter>();

    public virtual ICollection<ConcessionReleaseRecord> ConcessionReleaseRecords { get; set; } = new List<ConcessionReleaseRecord>();

    public virtual ICollection<Container> ContainerCreators { get; set; } = new List<Container>();

    public virtual ICollection<ContainerGenerateRecord> ContainerGenerateRecords { get; set; } = new List<ContainerGenerateRecord>();

    public virtual ICollection<Container> ContainerPackingUsers { get; set; } = new List<Container>();

    public virtual ICollection<CurrentActivedWorkOrderInformation> CurrentActivedWorkOrderInformations { get; set; } = new List<CurrentActivedWorkOrderInformation>();

    public virtual ICollection<CurrentToolingSetupInformation> CurrentToolingSetupInformations { get; set; } = new List<CurrentToolingSetupInformation>();

    public virtual ICollection<CustomerBoxInformation> CustomerBoxInformations { get; set; } = new List<CustomerBoxInformation>();

    public virtual ICollection<Customer> CustomerCreators { get; set; } = new List<Customer>();

    public virtual ICollection<Customer> CustomerEditors { get; set; } = new List<Customer>();

    public virtual ICollection<EDocument> EDocumentEditors { get; set; } = new List<EDocument>();

    public virtual ICollection<EDocument> EDocumentInitiators { get; set; } = new List<EDocument>();

    public virtual ICollection<Event> EventActionOwners { get; set; } = new List<Event>();

    public virtual ICollection<EventActionRecord> EventActionRecords { get; set; } = new List<EventActionRecord>();

    public virtual ICollection<EventEscalationProcess> EventEscalationProcessCreators { get; set; } = new List<EventEscalationProcess>();

    public virtual ICollection<EventEscalationProcess> EventEscalationProcessEditors { get; set; } = new List<EventEscalationProcess>();

    public virtual ICollection<EventEvaluationRecord> EventEvaluationRecords { get; set; } = new List<EventEvaluationRecord>();

    public virtual ICollection<EventKnowledgeLibrary> EventKnowledgeLibraries { get; set; } = new List<EventKnowledgeLibrary>();

    public virtual ICollection<EventProcessChangeLog> EventProcessChangeLogs { get; set; } = new List<EventProcessChangeLog>();

    public virtual ICollection<Event> EventReportUsers { get; set; } = new List<Event>();

    public virtual ICollection<Event> EventSigners { get; set; } = new List<Event>();

    public virtual ICollection<EventSubscription> EventSubscriptionCreators { get; set; } = new List<EventSubscription>();

    public virtual ICollection<EventSubscription> EventSubscriptionEditors { get; set; } = new List<EventSubscription>();

    public virtual ICollection<EventSubscription> EventSubscriptionSubscriberUsers { get; set; } = new List<EventSubscription>();

    public virtual Factory? Factory { get; set; }

    public virtual ICollection<IPQCForm> IPQCFormCreators { get; set; } = new List<IPQCForm>();

    public virtual ICollection<IPQCForm> IPQCFormEditors { get; set; } = new List<IPQCForm>();

    public virtual ICollection<IPQCRecord> IPQCRecords { get; set; } = new List<IPQCRecord>();

    public virtual ICollection<IQCForm> IQCFormCreators { get; set; } = new List<IQCForm>();

    public virtual ICollection<IQCForm> IQCFormEditors { get; set; } = new List<IQCForm>();

    public virtual ICollection<IQCRecord> IQCRecords { get; set; } = new List<IQCRecord>();

    public virtual ICollection<IdModel> IdModelCreators { get; set; } = new List<IdModel>();

    public virtual ICollection<IdModel> IdModelEditors { get; set; } = new List<IdModel>();

    public virtual ICollection<JPH> JPHCreators { get; set; } = new List<JPH>();

    public virtual ICollection<JPH> JPHEditors { get; set; } = new List<JPH>();

    public virtual ICollection<Location> LocationCreators { get; set; } = new List<Location>();

    public virtual ICollection<Location> LocationEditors { get; set; } = new List<Location>();

    public virtual ICollection<LockUnlockPartSNRecord> LockUnlockPartSNRecords { get; set; } = new List<LockUnlockPartSNRecord>();

    public virtual ICollection<MSATest> MSATestCreators { get; set; } = new List<MSATest>();

    public virtual ICollection<MSATest> MSATestEditors { get; set; } = new List<MSATest>();

    public virtual ICollection<MSATestRecord> MSATestRecords { get; set; } = new List<MSATestRecord>();

    public virtual ICollection<Machine> MachineCreators { get; set; } = new List<Machine>();

    public virtual ICollection<MachineCurrentToolingSetupDatum> MachineCurrentToolingSetupData { get; set; } = new List<MachineCurrentToolingSetupDatum>();

    public virtual ICollection<Machine> MachineEditors { get; set; } = new List<Machine>();

    public virtual ICollection<MaterialCheckInformation> MaterialCheckInformations { get; set; } = new List<MaterialCheckInformation>();

    public virtual ICollection<MaterialPool> MaterialPools { get; set; } = new List<MaterialPool>();

    public virtual ICollection<MaterialReceivingFormItem> MaterialReceivingFormItems { get; set; } = new List<MaterialReceivingFormItem>();

    public virtual ICollection<MaterialRequestForm> MaterialRequestFormCreators { get; set; } = new List<MaterialRequestForm>();

    public virtual ICollection<MaterialRequestForm> MaterialRequestFormEditors { get; set; } = new List<MaterialRequestForm>();

    public virtual ICollection<Material_SupplierMaterialBarcode> Material_SupplierMaterialBarcodes { get; set; } = new List<Material_SupplierMaterialBarcode>();

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();

    public virtual ICollection<Menu> MenuCreators { get; set; } = new List<Menu>();

    public virtual ICollection<Menu> MenuEditors { get; set; } = new List<Menu>();

    public virtual ICollection<MessageType> MessageTypeCreators { get; set; } = new List<MessageType>();

    public virtual ICollection<MessageType> MessageTypeEditors { get; set; } = new List<MessageType>();

    public virtual ICollection<MovementRecord> MovementRecords { get; set; } = new List<MovementRecord>();

    public virtual ICollection<OperationStep> OperationStepCreators { get; set; } = new List<OperationStep>();

    public virtual ICollection<OperationStep> OperationStepEditors { get; set; } = new List<OperationStep>();

    public virtual ICollection<PackingInformation> PackingInformations { get; set; } = new List<PackingInformation>();

    public virtual ICollection<PartMaterialRecordHi> PartMaterialRecordHis { get; set; } = new List<PartMaterialRecordHi>();

    public virtual ICollection<PartMaterialRecord> PartMaterialRecords { get; set; } = new List<PartMaterialRecord>();

    public virtual ICollection<PartMergeRecord> PartMergeRecords { get; set; } = new List<PartMergeRecord>();

    public virtual ICollection<PartProcessRecord> PartProcessRecords { get; set; } = new List<PartProcessRecord>();

    public virtual ICollection<PartRepairQualityCheckRecord> PartRepairQualityCheckRecords { get; set; } = new List<PartRepairQualityCheckRecord>();

    public virtual ICollection<PartRepairRecord> PartRepairRecords { get; set; } = new List<PartRepairRecord>();

    public virtual Platform Platform { get; set; } = null!;

    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();

    public virtual ICollection<ProductModel> ProductModelCreators { get; set; } = new List<ProductModel>();

    public virtual ICollection<ProductModel> ProductModelEditors { get; set; } = new List<ProductModel>();

    public virtual ICollection<ProductionPlan> ProductionPlanCreators { get; set; } = new List<ProductionPlan>();

    public virtual ICollection<ProductionPlan> ProductionPlanEditors { get; set; } = new List<ProductionPlan>();

    public virtual ICollection<QualityHoldForm> QualityHoldFormCreators { get; set; } = new List<QualityHoldForm>();

    public virtual ICollection<QualityHoldForm> QualityHoldFormEditors { get; set; } = new List<QualityHoldForm>();

    public virtual ICollection<QualityHoldFormItem> QualityHoldFormItems { get; set; } = new List<QualityHoldFormItem>();

    public virtual ICollection<QualityUnHoldFormItem> QualityUnHoldFormItems { get; set; } = new List<QualityUnHoldFormItem>();

    public virtual ICollection<QualityUnHoldForm> QualityUnHoldForms { get; set; } = new List<QualityUnHoldForm>();

    public virtual ICollection<Recipe> RecipeCreators { get; set; } = new List<Recipe>();

    public virtual ICollection<Recipe> RecipeEditors { get; set; } = new List<Recipe>();

    public virtual ICollection<RecipeItem> RecipeItemCreators { get; set; } = new List<RecipeItem>();

    public virtual ICollection<RecipeItem> RecipeItemEditors { get; set; } = new List<RecipeItem>();

    public virtual ICollection<ReworkRecord> ReworkRecords { get; set; } = new List<ReworkRecord>();

    public virtual ICollection<RoleAuth> RoleAuthCreators { get; set; } = new List<RoleAuth>();

    public virtual ICollection<RoleAuth> RoleAuthEditors { get; set; } = new List<RoleAuth>();

    public virtual ICollection<Roles_User> Roles_Users { get; set; } = new List<Roles_User>();

    public virtual ICollection<SMTChangeOverTableSetup> SMTChangeOverTableSetups { get; set; } = new List<SMTChangeOverTableSetup>();

    public virtual ICollection<SMTMachine> SMTMachines { get; set; } = new List<SMTMachine>();

    public virtual ICollection<SMTOnlineProgram> SMTOnlinePrograms { get; set; } = new List<SMTOnlineProgram>();

    public virtual ICollection<SMTOnlineSetup> SMTOnlineSetups { get; set; } = new List<SMTOnlineSetup>();

    public virtual ICollection<SMTSetup> SMTSetupCreators { get; set; } = new List<SMTSetup>();

    public virtual ICollection<SMTSetup> SMTSetupEditors { get; set; } = new List<SMTSetup>();

    public virtual ICollection<SerialNumberRegex> SerialNumberRegexes { get; set; } = new List<SerialNumberRegex>();

    public virtual ICollection<SerialNumberSwitchRecord> SerialNumberSwitchRecords { get; set; } = new List<SerialNumberSwitchRecord>();

    public virtual ICollection<SetupRecord> SetupRecords { get; set; } = new List<SetupRecord>();

    public virtual ICollection<SolderPasteEventHistory> SolderPasteEventHistories { get; set; } = new List<SolderPasteEventHistory>();

    public virtual ICollection<SolderPrintingSetting> SolderPrintingSettingCreators { get; set; } = new List<SolderPrintingSetting>();

    public virtual ICollection<SolderPrintingSetting> SolderPrintingSettingEditors { get; set; } = new List<SolderPrintingSetting>();

    public virtual ICollection<SqueegeEventHistory> SqueegeEventHistories { get; set; } = new List<SqueegeEventHistory>();

    public virtual ICollection<Station> StationCreators { get; set; } = new List<Station>();

    public virtual ICollection<Station> StationEditors { get; set; } = new List<Station>();

    public virtual ICollection<StationGroup> StationGroups { get; set; } = new List<StationGroup>();

    public virtual ICollection<StationParameter> StationParameters { get; set; } = new List<StationParameter>();

    public virtual ICollection<Station_StationGroup> Station_StationGroups { get; set; } = new List<Station_StationGroup>();

    public virtual ICollection<Supplier> SupplierCreators { get; set; } = new List<Supplier>();

    public virtual ICollection<Supplier> SupplierEditors { get; set; } = new List<Supplier>();

    public virtual ICollection<TPMReminder> TPMReminderCreators { get; set; } = new List<TPMReminder>();

    public virtual ICollection<TPMReminder> TPMReminderEditors { get; set; } = new List<TPMReminder>();

    public virtual ICollection<TPMWorkOrder> TPMWorkOrderCreators { get; set; } = new List<TPMWorkOrder>();

    public virtual ICollection<TPMWorkOrder> TPMWorkOrderEditors { get; set; } = new List<TPMWorkOrder>();

    public virtual ICollection<TPMWorkOrderItemTransferRecord> TPMWorkOrderItemTransferRecordFromOwners { get; set; } = new List<TPMWorkOrderItemTransferRecord>();

    public virtual ICollection<TPMWorkOrderItemTransferRecord> TPMWorkOrderItemTransferRecordInitiators { get; set; } = new List<TPMWorkOrderItemTransferRecord>();

    public virtual ICollection<TPMWorkOrderItemTransferRecord> TPMWorkOrderItemTransferRecordToOwners { get; set; } = new List<TPMWorkOrderItemTransferRecord>();

    public virtual ICollection<TPMWorkOrderItem> TPMWorkOrderItems { get; set; } = new List<TPMWorkOrderItem>();

    public virtual ICollection<TPMWorkPlan> TPMWorkPlanCreators { get; set; } = new List<TPMWorkPlan>();

    public virtual ICollection<TPMWorkPlan> TPMWorkPlanEditors { get; set; } = new List<TPMWorkPlan>();

    public virtual ICollection<Tooling> ToolingCreators { get; set; } = new List<Tooling>();

    public virtual ICollection<Tooling> ToolingEditors { get; set; } = new List<Tooling>();

    public virtual ICollection<ToolingLifeCheckRule> ToolingLifeCheckRuleCreators { get; set; } = new List<ToolingLifeCheckRule>();

    public virtual ICollection<ToolingLifeCheckRule> ToolingLifeCheckRuleEditors { get; set; } = new List<ToolingLifeCheckRule>();

    public virtual ICollection<ToolingType> ToolingTypeCreators { get; set; } = new List<ToolingType>();

    public virtual ICollection<ToolingType> ToolingTypeEditors { get; set; } = new List<ToolingType>();

    public virtual ICollection<UserFingerprint> UserFingerprints { get; set; } = new List<UserFingerprint>();

    public virtual ICollection<WMSForm> WMSFormCreators { get; set; } = new List<WMSForm>();

    public virtual ICollection<WMSForm> WMSFormEditors { get; set; } = new List<WMSForm>();

    public virtual ICollection<WorkOrder> WorkOrderCreators { get; set; } = new List<WorkOrder>();

    public virtual ICollection<WorkOrder> WorkOrderEditors { get; set; } = new List<WorkOrder>();

    public virtual ICollection<WorkOrderMaterialRecord> WorkOrderMaterialRecords { get; set; } = new List<WorkOrderMaterialRecord>();

    public virtual ICollection<WorkOrderProcessRecord> WorkOrderProcessRecords { get; set; } = new List<WorkOrderProcessRecord>();

    public virtual ICollection<WorkOrderQualityRecord> WorkOrderQualityRecords { get; set; } = new List<WorkOrderQualityRecord>();
}
