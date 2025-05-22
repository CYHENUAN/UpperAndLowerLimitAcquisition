using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Event
{
    public long Id { get; set; }

    public string EventCode { get; set; } = null!;

    public string? Title { get; set; }

    public int? EventSymptomId { get; set; }

    public string? Description { get; set; }

    public int? FactoryId { get; set; }

    public int? AreaId { get; set; }

    public int? StationId { get; set; }

    public int? EventCategoryId { get; set; }

    public int? Impact { get; set; }

    public int? Urgency { get; set; }

    public DateTime? IssueDateTime { get; set; }

    public DateTime? ReportDateTime { get; set; }

    public int? ReportUserId { get; set; }

    public DateTime? AssignedDateTime { get; set; }

    public DateTime? ActionStartedDateTime { get; set; }

    public DateTime? ActionFinishedDateTime { get; set; }

    public int? ActionOwnerRoleId { get; set; }

    public int? ActionOwnerId { get; set; }

    public string? Clarify { get; set; }

    public string? Solution { get; set; }

    public DateTime? SignedOffDateTime { get; set; }

    public int? SignerId { get; set; }

    public int? State { get; set; }

    public virtual User? ActionOwner { get; set; }

    public virtual Role? ActionOwnerRole { get; set; }

    public virtual Area? Area { get; set; }

    public virtual ICollection<EventActionRecord> EventActionRecords { get; set; } = new List<EventActionRecord>();

    public virtual EventCategory? EventCategory { get; set; }

    public virtual ICollection<EventEvaluationRecord> EventEvaluationRecords { get; set; } = new List<EventEvaluationRecord>();

    public virtual ICollection<EventProcessChangeLog> EventProcessChangeLogs { get; set; } = new List<EventProcessChangeLog>();

    public virtual EventSymptom? EventSymptom { get; set; }

    public virtual ICollection<Event_KnowledgeLib> Event_KnowledgeLibs { get; set; } = new List<Event_KnowledgeLib>();

    public virtual Factory? Factory { get; set; }

    public virtual User? ReportUser { get; set; }

    public virtual User? Signer { get; set; }

    public virtual Station? Station { get; set; }
}
