using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Unit
{
    public int Id { get; set; }

    public string UnitCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? State { get; set; }

    public virtual ICollection<MSATest> MSATests { get; set; } = new List<MSATest>();

    public virtual ICollection<MaterialCheckBillFormItem> MaterialCheckBillFormItems { get; set; } = new List<MaterialCheckBillFormItem>();

    public virtual ICollection<MaterialOtherMovementFormItem> MaterialOtherMovementFormItems { get; set; } = new List<MaterialOtherMovementFormItem>();

    public virtual ICollection<MaterialPickingFormItem> MaterialPickingFormItems { get; set; } = new List<MaterialPickingFormItem>();

    public virtual ICollection<MaterialReceivingFormItem> MaterialReceivingFormItems { get; set; } = new List<MaterialReceivingFormItem>();

    public virtual ICollection<MaterialRequestFormItem> MaterialRequestFormItems { get; set; } = new List<MaterialRequestFormItem>();

    public virtual ICollection<MaterialReturnFormItem> MaterialReturnFormItems { get; set; } = new List<MaterialReturnFormItem>();

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();

    public virtual ICollection<ProductInStockingFormItem> ProductInStockingFormItems { get; set; } = new List<ProductInStockingFormItem>();

    public virtual ICollection<TPMWorkPlanItem> TPMWorkPlanItems { get; set; } = new List<TPMWorkPlanItem>();

    public virtual ICollection<ToolingLifeCheckRule> ToolingLifeCheckRules { get; set; } = new List<ToolingLifeCheckRule>();

    public virtual ICollection<WMSWorkOrder> WMSWorkOrders { get; set; } = new List<WMSWorkOrder>();

    public virtual ICollection<WorkOrderMaterialRecord> WorkOrderMaterialRecords { get; set; } = new List<WorkOrderMaterialRecord>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
