using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EventActionRecord
{
    public long Id { get; set; }

    public long EventId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public string ActionDetail { get; set; } = null!;

    public int ActionUserId { get; set; }

    public virtual User ActionUser { get; set; } = null!;

    public virtual Event Event { get; set; } = null!;
}
