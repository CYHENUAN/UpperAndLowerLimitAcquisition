using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MachineRunningInformation
{
    public long Id { get; set; }

    public string? MachineNumber { get; set; }

    public string? RunningState { get; set; }

    public double? CycleTime { get; set; }

    public int? PartTypeInPLC { get; set; }

    public string? PartSN { get; set; }
}
