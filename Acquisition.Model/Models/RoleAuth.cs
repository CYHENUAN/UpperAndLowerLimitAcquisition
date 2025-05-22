using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class RoleAuth
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public int MenuId { get; set; }

    public string? AuthValue { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual Menu Menu { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
