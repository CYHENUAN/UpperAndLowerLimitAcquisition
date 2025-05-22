using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EventSymptom
{
    public int Id { get; set; }

    public int? FactoryId { get; set; }

    public string SymptomCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? DefaultImpact { get; set; }

    public int? DefaultUrgency { get; set; }

    public virtual ICollection<EventSubscription> EventSubscriptions { get; set; } = new List<EventSubscription>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Factory? Factory { get; set; }
}
