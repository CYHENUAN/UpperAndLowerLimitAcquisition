using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SqueegeType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Squeege> Squeeges { get; set; } = new List<Squeege>();
}
