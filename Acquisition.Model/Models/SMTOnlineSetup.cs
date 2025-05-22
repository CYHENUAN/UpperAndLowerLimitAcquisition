using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTOnlineSetup
{
    public int Id { get; set; }

    public int SMTLineId { get; set; }

    public int SMTMachineAreaId { get; set; }

    public string? MaterialLocation { get; set; }

    public long? ContainerId { get; set; }

    public long? NewContainerId { get; set; }

    public DateTime? SetupDateTime { get; set; }

    public int? CreatorId { get; set; }

    public int SetupId { get; set; }

    public virtual Container? Container { get; set; }

    public virtual User? Creator { get; set; }

    public virtual Container? NewContainer { get; set; }

    public virtual SMTLine SMTLine { get; set; } = null!;

    public virtual SMTMachineArea SMTMachineArea { get; set; } = null!;

    public virtual SMTSetup Setup { get; set; } = null!;
}
