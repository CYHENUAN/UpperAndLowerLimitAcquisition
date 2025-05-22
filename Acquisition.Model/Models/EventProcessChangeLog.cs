using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EventProcessChangeLog
{
    public long Id { get; set; }

    public long EventId { get; set; }

    public DateTime ChangeDateTime { get; set; }

    public int ChangeUserId { get; set; }

    /// <summary>
    /// 1:
    /// </summary>
    public int ChangeType { get; set; }

    public virtual User ChangeUser { get; set; } = null!;

    public virtual Event Event { get; set; } = null!;

    public virtual ICollection<EventProcessChangeDetail> EventProcessChangeDetails { get; set; } = new List<EventProcessChangeDetail>();
}
