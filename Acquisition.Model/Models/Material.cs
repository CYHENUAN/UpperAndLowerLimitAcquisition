using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Material
{
    public int Id { get; set; }

    public string MaterialNumber { get; set; } = null!;

    public int Version { get; set; }

    public string Description { get; set; } = null!;

    public string? Specification { get; set; }

    public string? CustomerMaterialNumber { get; set; }

    public string? SupplierMaterialNumber { get; set; }

    public int? MaterialGroupType { get; set; }

    public bool IsProduct { get; set; }

    public bool IsMultiPanel { get; set; }

    public bool? RequireBackflush { get; set; }

    public int NumberOfPanels { get; set; }

    public int Unit { get; set; }

    public bool? SetupFlag { get; set; }

    public int? ProcurementType { get; set; }

    public decimal? MinimumPackageQuantity { get; set; }

    public decimal? ExpirationTime { get; set; }

    public decimal? SafetyStock { get; set; }

    public int? DefaultStorageLocationId { get; set; }

    public int? DefaultTargetFeedingLocationId { get; set; }

    public int? ContainerSize { get; set; }

    public int? MSL { get; set; }

    /// <summary>
    /// 0:Deactive, 1:Active
    /// </summary>
    public int State { get; set; }

    public int? DefaultStationGroupId { get; set; }

    public int? CompanyId { get; set; }

    public int? FactoryId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? ValidBegin { get; set; }

    public DateTime? ValidEnd { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public string? ProjectName { get; set; }

    public string? OriginalNumber { get; set; }

    public string? CADDrawingPartNumber { get; set; }

    public bool? RequireFIFO { get; set; }

    public bool? RequireCheckCustomerLabel { get; set; }

    public string? ContainerNumberRegEx { get; set; }

    public virtual ICollection<BOMHead> BOMHeads { get; set; } = new List<BOMHead>();

    public virtual ICollection<BOMItem> BOMItems { get; set; } = new List<BOMItem>();

    public virtual Company? Company { get; set; }

    public virtual ICollection<Container> Containers { get; set; } = new List<Container>();

    public virtual User? Creator { get; set; }

    public virtual StationGroup? DefaultStationGroup { get; set; }

    public virtual Location? DefaultStorageLocation { get; set; }

    public virtual Location? DefaultTargetFeedingLocation { get; set; }

    public virtual ICollection<EDocument_Relationship> EDocument_Relationships { get; set; } = new List<EDocument_Relationship>();

    public virtual Factory? Factory { get; set; }

    public virtual ICollection<IQCForm> IQCForms { get; set; } = new List<IQCForm>();

    public virtual ICollection<IdCounter> IdCounters { get; set; } = new List<IdCounter>();

    public virtual ICollection<JPH> JPHs { get; set; } = new List<JPH>();

    public virtual MSL? MSLNavigation { get; set; }

    public virtual ICollection<MaterialCheckBillFormItem> MaterialCheckBillFormItems { get; set; } = new List<MaterialCheckBillFormItem>();

    public virtual MaterialGroup? MaterialGroupTypeNavigation { get; set; }

    public virtual ICollection<MaterialOtherMovementFormItem> MaterialOtherMovementFormItems { get; set; } = new List<MaterialOtherMovementFormItem>();

    public virtual ICollection<MaterialPickingFormItem> MaterialPickingFormItems { get; set; } = new List<MaterialPickingFormItem>();

    public virtual ICollection<MaterialReceivingFormItem> MaterialReceivingFormItems { get; set; } = new List<MaterialReceivingFormItem>();

    public virtual ICollection<MaterialRequestFormItem> MaterialRequestFormItems { get; set; } = new List<MaterialRequestFormItem>();

    public virtual ICollection<MaterialReturnFormItem> MaterialReturnFormItems { get; set; } = new List<MaterialReturnFormItem>();

    public virtual ICollection<Material_Process> Material_Processes { get; set; } = new List<Material_Process>();

    public virtual ICollection<Material_SupplierMaterialBarcode> Material_SupplierMaterialBarcodes { get; set; } = new List<Material_SupplierMaterialBarcode>();

    public virtual ICollection<PartSerialNumber> PartSerialNumbers { get; set; } = new List<PartSerialNumber>();

    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();

    public virtual ProcurementType? ProcurementTypeNavigation { get; set; }

    public virtual ICollection<ProductDeliveryRequestFormItem> ProductDeliveryRequestFormItems { get; set; } = new List<ProductDeliveryRequestFormItem>();

    public virtual ICollection<ProductInStockingFormItem> ProductInStockingFormItems { get; set; } = new List<ProductInStockingFormItem>();

    public virtual ICollection<ProductModel> ProductModels { get; set; } = new List<ProductModel>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual ICollection<SMTProgramDetail> SMTProgramDetails { get; set; } = new List<SMTProgramDetail>();

    public virtual ICollection<SMTProgram> SMTPrograms { get; set; } = new List<SMTProgram>();

    public virtual ICollection<SMTSetupListItem> SMTSetupListItems { get; set; } = new List<SMTSetupListItem>();

    public virtual ICollection<SerialNumberRegex> SerialNumberRegexes { get; set; } = new List<SerialNumberRegex>();

    public virtual ICollection<TPMMaterialRecord> TPMMaterialRecords { get; set; } = new List<TPMMaterialRecord>();

    public virtual ICollection<TPMWorkOrderItem> TPMWorkOrderItems { get; set; } = new List<TPMWorkOrderItem>();

    public virtual ICollection<TPMWorkPlanItem> TPMWorkPlanItems { get; set; } = new List<TPMWorkPlanItem>();

    public virtual ICollection<ToolingType> ToolingTypes { get; set; } = new List<ToolingType>();

    public virtual Unit UnitNavigation { get; set; } = null!;

    public virtual ICollection<WMSWorkOrder> WMSWorkOrders { get; set; } = new List<WMSWorkOrder>();
}
