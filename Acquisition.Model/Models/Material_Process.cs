using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Material_Process
{
    public int Id { get; set; }

    public int MaterialId { get; set; }

    public int ProcessId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual Process Process { get; set; } = null!;
}
