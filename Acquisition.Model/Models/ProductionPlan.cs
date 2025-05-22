using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ProductionPlan
{
    public int ID { get; set; }

    public string Name { get; set; } = null!;

    public int Quantity { get; set; }

    public DateOnly PlanDate { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int? ShiftId { get; set; }

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual ICollection<ProductionPlanRecord> ProductionPlanRecords { get; set; } = new List<ProductionPlanRecord>();

    public virtual Shift? Shift { get; set; }
}
