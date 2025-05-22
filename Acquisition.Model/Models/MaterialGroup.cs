using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialGroup
{
    public int Id { get; set; }

    public string MaterialGroupCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<IdCounter> IdCounters { get; set; } = new List<IdCounter>();

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
