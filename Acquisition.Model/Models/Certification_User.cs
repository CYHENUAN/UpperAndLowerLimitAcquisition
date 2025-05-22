using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Certification_User
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int StationGroupId { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual StationGroup StationGroup { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
