using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTProgramDetail
{
    public int Id { get; set; }

    public int SMTProgramId { get; set; }

    public int SMTMachineAreaId { get; set; }

    public string MaterialLocation { get; set; } = null!;

    public int MaterialId { get; set; }

    public string Designator { get; set; } = null!;

    public string? ComponentShapeCode { get; set; }

    public decimal? XPosition { get; set; }

    public decimal? YPosition { get; set; }

    public decimal? Angel { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual SMTMachineArea SMTMachineArea { get; set; } = null!;

    public virtual SMTProgram SMTProgram { get; set; } = null!;
}
