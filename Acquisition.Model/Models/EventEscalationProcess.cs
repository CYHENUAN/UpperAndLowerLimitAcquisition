using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EventEscalationProcess
{
    public int Id { get; set; }

    public string EscalationProcessCode { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime? CreationDatetime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int? State { get; set; }

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual ICollection<EventCategory> EventCategories { get; set; } = new List<EventCategory>();

    public virtual ICollection<EventEscalationProcessStep> EventEscalationProcessSteps { get; set; } = new List<EventEscalationProcessStep>();
}
