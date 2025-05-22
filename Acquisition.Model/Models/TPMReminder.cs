using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class TPMReminder
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int TPMWorkPlanId { get; set; }

    public string? Description { get; set; }

    public string CORNExpression { get; set; } = null!;

    public DateTime CreationDateTime { get; set; }

    public int CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int State { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual TPMWorkPlan TPMWorkPlan { get; set; } = null!;
}
