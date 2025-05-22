using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EventSubscription
{
    public int Id { get; set; }

    public int EventCategoryId { get; set; }

    public int Impact { get; set; }

    public int Urgency { get; set; }

    public int EventSymptomId { get; set; }

    public int? SubscriberUserId { get; set; }

    public int? SubscriberRoleId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int? State { get; set; }

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual EventCategory EventCategory { get; set; } = null!;

    public virtual EventSymptom EventSymptom { get; set; } = null!;

    public virtual Role? SubscriberRole { get; set; }

    public virtual User? SubscriberUser { get; set; }
}
