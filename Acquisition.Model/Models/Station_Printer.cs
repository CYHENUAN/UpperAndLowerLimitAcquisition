using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Station_Printer
{
    public int Id { get; set; }

    public int StationId { get; set; }

    public int Secquence { get; set; }

    public string? PrintName { get; set; }

    public virtual Station Station { get; set; } = null!;
}
