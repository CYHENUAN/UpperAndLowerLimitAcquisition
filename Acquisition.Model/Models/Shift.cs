using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Shift
{
    public int Id { get; set; }

    public string? ShiftCode { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public TimeOnly? BeginTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public virtual ICollection<ProductionPlan> ProductionPlans { get; set; } = new List<ProductionPlan>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
