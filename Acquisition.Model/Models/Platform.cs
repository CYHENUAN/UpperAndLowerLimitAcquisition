using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Platform
{
    public int Id { get; set; }

    public string PlatformName { get; set; } = null!;

    public DateTime CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int IsEnable { get; set; }

    public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
