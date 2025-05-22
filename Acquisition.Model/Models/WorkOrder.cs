using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class WorkOrder
{
    public long Id { get; set; }

    public string WorkOrderNumber { get; set; } = null!;

    public int BOMHeadId { get; set; }

    public int ProcessId { get; set; }

    public int UnitId { get; set; }

    public int? LineId { get; set; }

    public int? ShiftId { get; set; }

    public decimal PlannedQuantity { get; set; }

    public decimal? ActualBuiltQuantity { get; set; }

    public DateTime? PlannedStartDateTime { get; set; }

    public DateTime? PlannedFinishDateTime { get; set; }

    public DateTime? ActualStartDateTime { get; set; }

    public DateTime? ActualFinishedDateTime { get; set; }

    public string? Comment { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    /// <summary>
    /// 0:Planned/New,10:Started,100:Completed,99:Closed
    /// </summary>
    public int State { get; set; }

    public int? FactoryId { get; set; }

    /// <summary>
    /// 0:normal,1:virtual
    /// </summary>
    public int Type { get; set; }

    public decimal? ActualInputQuantity { get; set; }

    public virtual BOMHead BOMHead { get; set; } = null!;

    public virtual ICollection<ConcessionReleaseRecord> ConcessionReleaseRecords { get; set; } = new List<ConcessionReleaseRecord>();

    public virtual User Creator { get; set; } = null!;

    public virtual ICollection<CurrentActivedWorkOrderInformation> CurrentActivedWorkOrderInformations { get; set; } = new List<CurrentActivedWorkOrderInformation>();

    public virtual ICollection<EDocument_Relationship> EDocument_Relationships { get; set; } = new List<EDocument_Relationship>();

    public virtual User? Editor { get; set; }

    public virtual ICollection<FISWorkOrder> FISWorkOrders { get; set; } = new List<FISWorkOrder>();

    public virtual Factory? Factory { get; set; }

    public virtual Cell? Line { get; set; }

    public virtual ICollection<LockUnlockPartSNRecord> LockUnlockPartSNRecords { get; set; } = new List<LockUnlockPartSNRecord>();

    public virtual ICollection<MaterialPickingForm> MaterialPickingForms { get; set; } = new List<MaterialPickingForm>();

    public virtual ICollection<PartSerialNumber> PartSerialNumbers { get; set; } = new List<PartSerialNumber>();

    public virtual Process Process { get; set; } = null!;

    public virtual ICollection<ProductInStockingFormItem> ProductInStockingFormItems { get; set; } = new List<ProductInStockingFormItem>();

    public virtual ICollection<ReworkRecord> ReworkRecords { get; set; } = new List<ReworkRecord>();

    public virtual Shift? Shift { get; set; }

    public virtual Unit Unit { get; set; } = null!;

    public virtual ICollection<WorkOrderProcessRecord> WorkOrderProcessRecords { get; set; } = new List<WorkOrderProcessRecord>();

    public virtual ICollection<WorkOrder_Cell> WorkOrder_Cells { get; set; } = new List<WorkOrder_Cell>();
}
