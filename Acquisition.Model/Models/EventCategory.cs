using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EventCategory
{
    public int Id { get; set; }

    public int? FactoryId { get; set; }

    public string? CategoryCode { get; set; }

    public int? ParentCategoryId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? DefaultOwnerRoleId { get; set; }

    public int? DefaultEscalationProcessId { get; set; }

    public virtual EventEscalationProcess? DefaultEscalationProcess { get; set; }

    public virtual Role? DefaultOwnerRole { get; set; }

    public virtual ICollection<EventSubscription> EventSubscriptions { get; set; } = new List<EventSubscription>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Factory? Factory { get; set; }
}
