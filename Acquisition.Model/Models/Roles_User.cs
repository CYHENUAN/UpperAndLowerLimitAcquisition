using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Roles_User
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public int UserId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int CreatorId { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
