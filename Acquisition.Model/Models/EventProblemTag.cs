using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EventProblemTag
{
    public int Id { get; set; }

    public string TagName { get; set; } = null!;

    public virtual ICollection<KnowledgeLib_ProblemTag> KnowledgeLib_ProblemTags { get; set; } = new List<KnowledgeLib_ProblemTag>();
}
