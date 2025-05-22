using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Menu
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public string? Name { get; set; }

    public string? FontFamily { get; set; }

    public string? Icon { get; set; }

    public string? Url { get; set; }

    public int? SortCode { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int? State { get; set; }

    public string? Auth { get; set; }

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual ICollection<RoleAuth> RoleAuths { get; set; } = new List<RoleAuth>();
}
