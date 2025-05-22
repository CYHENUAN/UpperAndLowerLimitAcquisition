using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class FailureType_Station
{
    public int Id { get; set; }

    public int FailureTypeId { get; set; }

    public int StationId { get; set; }

    public DateTime AssignedDateTime { get; set; }

    public virtual FailureType FailureType { get; set; } = null!;

    public virtual Station Station { get; set; } = null!;
}
