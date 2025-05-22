using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class JPH
{
    public int Id { get; set; }

    public int LineLocationId { get; set; }

    public int MaterialId { get; set; }

    public decimal JPH1 { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? State { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual Location LineLocation { get; set; } = null!;

    public virtual Material Material { get; set; } = null!;
}
