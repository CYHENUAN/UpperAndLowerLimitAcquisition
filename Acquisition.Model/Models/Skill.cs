using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Skill
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Status { get; set; }

    public string? Level { get; set; }

    public virtual ICollection<Certification> Certifications { get; set; } = new List<Certification>();

    public virtual ICollection<Stations_Skill> Stations_Skills { get; set; } = new List<Stations_Skill>();
}
