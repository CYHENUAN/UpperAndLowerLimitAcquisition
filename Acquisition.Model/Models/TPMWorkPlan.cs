using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class TPMWorkPlan
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int MachineId { get; set; }

    public int State { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? WorkPlanTypeId { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual Machine Machine { get; set; } = null!;

    public virtual ICollection<TPMReminder> TPMReminders { get; set; } = new List<TPMReminder>();

    public virtual ICollection<TPMWorkOrder_TPMWorkPlan> TPMWorkOrder_TPMWorkPlans { get; set; } = new List<TPMWorkOrder_TPMWorkPlan>();

    public virtual ICollection<TPMWorkPlanItem> TPMWorkPlanItems { get; set; } = new List<TPMWorkPlanItem>();
}
