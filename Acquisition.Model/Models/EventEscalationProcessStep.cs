using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EventEscalationProcessStep
{
    public int Id { get; set; }

    public int EscalationProcessId { get; set; }

    public int Sequence { get; set; }

    public decimal TimeThresholdInSecond { get; set; }

    public int? RoleIdToInform { get; set; }

    public virtual EventEscalationProcess EscalationProcess { get; set; } = null!;

    public virtual Role? RoleIdToInformNavigation { get; set; }
}
