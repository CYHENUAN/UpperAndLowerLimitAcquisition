using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Cell_Station
{
    public int Id { get; set; }

    public int CellId { get; set; }

    public int StationId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public virtual Cell Cell { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual Station Station { get; set; } = null!;
}
