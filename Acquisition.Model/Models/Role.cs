using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Role
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public int PlatformId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int State { get; set; }

    public int? FactoryId { get; set; }

    public string? Visit { get; set; }

    public string? AreaIdList { get; set; }

    public virtual ICollection<EventCategory> EventCategories { get; set; } = new List<EventCategory>();

    public virtual ICollection<EventEscalationProcessStep> EventEscalationProcessSteps { get; set; } = new List<EventEscalationProcessStep>();

    public virtual ICollection<EventSubscription> EventSubscriptions { get; set; } = new List<EventSubscription>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Factory? Factory { get; set; }

    public virtual Platform Platform { get; set; } = null!;

    public virtual ICollection<RoleAuth> RoleAuths { get; set; } = new List<RoleAuth>();

    public virtual ICollection<Role_Area> Role_Areas { get; set; } = new List<Role_Area>();

    public virtual ICollection<Roles_User> Roles_Users { get; set; } = new List<Roles_User>();

    public virtual ICollection<TPMWorkOrderItem> TPMWorkOrderItems { get; set; } = new List<TPMWorkOrderItem>();

    public virtual ICollection<TPMWorkPlanItem> TPMWorkPlanItems { get; set; } = new List<TPMWorkPlanItem>();
}
