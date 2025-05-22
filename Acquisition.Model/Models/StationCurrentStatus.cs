using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class StationCurrentStatus
{
    public int StationId { get; set; }

    public int Status { get; set; }

    public int? FailureId { get; set; }

    public DateTime UpdateDateTime { get; set; }

    public int? TotalOutput { get; set; }

    public int? GoodOutput { get; set; }

    public int? NGOutput { get; set; }

    public decimal? CycleTime { get; set; }
}
