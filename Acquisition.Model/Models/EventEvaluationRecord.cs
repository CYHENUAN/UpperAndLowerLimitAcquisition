using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EventEvaluationRecord
{
    public long Id { get; set; }

    public long EventId { get; set; }

    public int? EvaluateGrade { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? EvaluatorId { get; set; }

    public virtual User? Evaluator { get; set; }

    public virtual Event Event { get; set; } = null!;
}
