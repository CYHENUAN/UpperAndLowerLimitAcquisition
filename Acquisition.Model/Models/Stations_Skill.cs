using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Stations_Skill
{
    public int Id { get; set; }

    /// <summary>
    /// 1:StationGroup,2:Station
    /// </summary>
    public int Type { get; set; }

    public int? StationGroupId { get; set; }

    public int? StationId { get; set; }

    public int SkillId { get; set; }

    public virtual Skill Skill { get; set; } = null!;

    public virtual Station? Station { get; set; }

    public virtual StationGroup? StationGroup { get; set; }
}
