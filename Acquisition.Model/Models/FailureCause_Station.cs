using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class FailureCause_Station
{
    public int Id { get; set; }

    public int FailureCauseId { get; set; }

    public int StationId { get; set; }

    public DateTime AssignedDateTime { get; set; }

    public virtual FailureCause FailureCause { get; set; } = null!;

    public virtual Station Station { get; set; } = null!;
}
