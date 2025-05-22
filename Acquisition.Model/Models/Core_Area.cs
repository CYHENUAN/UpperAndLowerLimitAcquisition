using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Core_Area
{
    public long Id { get; set; }

    public int Status { get; set; }

    public DateTime CreationDateTime { get; set; }

    public DateTime? Stamp { get; set; }

    public DateTime? ProcessedDateTime { get; set; }

    public int OperationType { get; set; }

    public string? AreaCode { get; set; }

    public string? Name { get; set; }

    public int? Type { get; set; }
}
