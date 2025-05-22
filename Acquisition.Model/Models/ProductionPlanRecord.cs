using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ProductionPlanRecord
{
    public int ID { get; set; }

    public int ProductionPlanId { get; set; }

    public string? EventData { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? CreatorId { get; set; }

    public virtual ProductionPlan ProductionPlan { get; set; } = null!;
}
