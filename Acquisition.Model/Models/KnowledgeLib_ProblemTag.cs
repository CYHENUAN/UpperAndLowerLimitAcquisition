using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class KnowledgeLib_ProblemTag
{
    public long Id { get; set; }

    public long? EventKnowledgeLibId { get; set; }

    public int? EventProblemTagId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public virtual EventKnowledgeLibrary? EventKnowledgeLib { get; set; }

    public virtual EventProblemTag? EventProblemTag { get; set; }
}
