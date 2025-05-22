using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Factory
{
    public int Id { get; set; }

    public string FactoryCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? CompanyId { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<BOMHead> BOMHeads { get; set; } = new List<BOMHead>();

    public virtual ICollection<Cell> Cells { get; set; } = new List<Cell>();

    public virtual Company? Company { get; set; }

    public virtual ICollection<EventCategory> EventCategories { get; set; } = new List<EventCategory>();

    public virtual ICollection<EventSymptom> EventSymptoms { get; set; } = new List<EventSymptom>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();

    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<StationGroup> StationGroups { get; set; } = new List<StationGroup>();

    public virtual ICollection<Station> Stations { get; set; } = new List<Station>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
