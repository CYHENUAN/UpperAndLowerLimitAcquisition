using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MachineErrorInformation
{
    public long Id { get; set; }

    public string? ErrorSourceId { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? OccuredDateTime { get; set; }

    public DateTime? FixedDateTime { get; set; }

    public int? State { get; set; }
}
