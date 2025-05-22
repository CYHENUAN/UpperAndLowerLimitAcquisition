using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class TPMWorkOrder
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    /// <summary>
    /// 进度, 10: Created, 20 :Started, 30:Canceled,, 40:Pending, 100:Completed
    /// </summary>
    public int? Status { get; set; }

    public int? State { get; set; }

    public DateTime PlanStartDateTime { get; set; }

    public DateTime? PlanFinishDateTime { get; set; }

    public DateTime? DueDateTime { get; set; }

    public DateTime? ActualStartDateTime { get; set; }

    public DateTime? ActualFinishDateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual ICollection<TPMWorkOrderItem> TPMWorkOrderItems { get; set; } = new List<TPMWorkOrderItem>();

    public virtual ICollection<TPMWorkOrder_TPMWorkPlan> TPMWorkOrder_TPMWorkPlans { get; set; } = new List<TPMWorkOrder_TPMWorkPlan>();
}
