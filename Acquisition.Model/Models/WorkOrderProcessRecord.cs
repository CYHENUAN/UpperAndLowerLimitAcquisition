using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class WorkOrderProcessRecord
{
    public long Id { get; set; }

    public long WorkOrderId { get; set; }

    public int ProcessStepId { get; set; }

    public int StationId { get; set; }

    public int? OperatorId { get; set; }

    /// <summary>
    /// 10:Start work, 20: Report work
    /// </summary>
    public int State { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public decimal? GoodQuantity { get; set; }

    public decimal? NGQuantity { get; set; }

    /// <summary>
    /// 预留以后用
    /// </summary>
    public int? Status { get; set; }

    public string? Comment { get; set; }

    public virtual User? Operator { get; set; }

    public virtual ProcessStep ProcessStep { get; set; } = null!;

    public virtual Station Station { get; set; } = null!;

    public virtual WorkOrder WorkOrder { get; set; } = null!;

    public virtual ICollection<WorkOrderMaterialRecord> WorkOrderMaterialRecords { get; set; } = new List<WorkOrderMaterialRecord>();

    public virtual ICollection<WorkOrderQualityRecord> WorkOrderQualityRecords { get; set; } = new List<WorkOrderQualityRecord>();
}
