using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTChangeOverTableSetup
{
    public int Id { get; set; }

    public int SMTChangeOverTableId { get; set; }

    public string MaterialLocation { get; set; } = null!;

    public long ContainerId { get; set; }

    public DateTime? SetupDateTime { get; set; }

    public int? CreatorId { get; set; }

    public int SetupId { get; set; }

    public virtual Container Container { get; set; } = null!;

    public virtual User? Creator { get; set; }

    public virtual SMTChangeOverTable SMTChangeOverTable { get; set; } = null!;
}
