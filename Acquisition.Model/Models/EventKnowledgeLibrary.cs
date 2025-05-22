using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EventKnowledgeLibrary
{
    public long Id { get; set; }

    public string KnowledgeCode { get; set; } = null!;

    public int? Type { get; set; }

    public string Name { get; set; } = null!;

    public string ProblemDescription { get; set; } = null!;

    public string SolutionDescription { get; set; } = null!;

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public int? State { get; set; }

    public string? RootCauseDescription { get; set; }

    public virtual User? Creator { get; set; }

    public virtual ICollection<Event_KnowledgeLib> Event_KnowledgeLibs { get; set; } = new List<Event_KnowledgeLib>();

    public virtual ICollection<KnowledgeLib_ProblemTag> KnowledgeLib_ProblemTags { get; set; } = new List<KnowledgeLib_ProblemTag>();
}
