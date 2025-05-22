using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MSATest
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public int MachineId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int? Enable { get; set; }

    public int? Type { get; set; }

    public string? ItemName { get; set; }

    public decimal? USL { get; set; }

    public decimal? Norm { get; set; }

    public decimal? LSL { get; set; }

    public int? UnitId { get; set; }

    public int? SampleCount { get; set; }

    public int? SampleTestCount { get; set; }

    public int? SampleTestOperatorCount { get; set; }

    public decimal? EV { get; set; }

    public decimal? PV { get; set; }

    public decimal? AV { get; set; }

    public decimal? TV { get; set; }

    public decimal? GRR { get; set; }

    public decimal? XBarBar { get; set; }

    public decimal? XMin { get; set; }

    public decimal? XMax { get; set; }

    public decimal? RBarBar { get; set; }

    public decimal? R { get; set; }

    public decimal? UCL { get; set; }

    public decimal? LCL { get; set; }

    public decimal? Cp { get; set; }

    public decimal? Cpk { get; set; }

    public string? FinalResult { get; set; }

    public DateTime? ResultDateTime { get; set; }

    public int? State { get; set; }

    public DateTime? PlanDateTime { get; set; }

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual ICollection<MSATestRecord> MSATestRecords { get; set; } = new List<MSATestRecord>();

    public virtual Machine Machine { get; set; } = null!;

    public virtual Unit? Unit { get; set; }
}
