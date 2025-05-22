using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class StationStatusHi
{
    public long Id { get; set; }

    public int StationId { get; set; }

    public int Status { get; set; }

    public int? FailureId { get; set; }

    public DateTime EventDateTime { get; set; }

    public DateTime BookDateTime { get; set; }

    public int? Duration { get; set; }
}
