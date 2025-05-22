using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTChangeOverTable
{
    public int Id { get; set; }

    public string ChangeOverTableCode { get; set; } = null!;

    public int? CurrentMachineAreaId { get; set; }

    public int? State { get; set; }

    public virtual SMTMachineArea? CurrentMachineArea { get; set; }

    public virtual ICollection<SMTChangeOverTableSetup> SMTChangeOverTableSetups { get; set; } = new List<SMTChangeOverTableSetup>();
}
