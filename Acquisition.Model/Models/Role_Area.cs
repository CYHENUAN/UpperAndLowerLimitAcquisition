using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Role_Area
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public int AreaId { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
