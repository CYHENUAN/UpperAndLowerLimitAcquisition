using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MSATestRecord
{
    public int Id { get; set; }

    public int? MSATestId { get; set; }

    public int? TestCountNo { get; set; }

    public long? SampleId { get; set; }

    public string? SampleSerialNumber { get; set; }

    public int? OperatorId { get; set; }

    public decimal? TestResult { get; set; }

    public DateTime? TestDateTime { get; set; }

    public double? CycleTime { get; set; }

    public decimal? Xbar { get; set; }

    public decimal? R { get; set; }

    public decimal? Standard { get; set; }

    public virtual MSATest? MSATest { get; set; }

    public virtual User? Operator { get; set; }

    public virtual PartSerialNumber? Sample { get; set; }
}
