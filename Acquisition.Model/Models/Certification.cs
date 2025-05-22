using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Certification
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int UserId { get; set; }

    public int SkillId { get; set; }

    public int Status { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public DateTime? EditDateTime { get; set; }

    public DateTime? ExpireDateTime { get; set; }

    public virtual Skill Skill { get; set; } = null!;
}
