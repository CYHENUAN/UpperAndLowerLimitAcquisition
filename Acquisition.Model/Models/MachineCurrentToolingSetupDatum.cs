using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MachineCurrentToolingSetupDatum
{
    public int Id { get; set; }

    public int? MachineId { get; set; }

    public int StationId { get; set; }

    public string ToolingHoleNumber { get; set; } = null!;

    public long ToolingId { get; set; }

    public DateTime SetupDateTime { get; set; }

    public int OperatorId { get; set; }

    public virtual Machine? Machine { get; set; }

    public virtual User Operator { get; set; } = null!;

    public virtual Station Station { get; set; } = null!;

    public virtual Tooling Tooling { get; set; } = null!;
}
