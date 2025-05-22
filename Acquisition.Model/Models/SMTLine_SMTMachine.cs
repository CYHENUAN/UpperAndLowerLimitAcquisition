using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTLine_SMTMachine
{
    public int Id { get; set; }

    public int Sequence { get; set; }

    public int SMTLineId { get; set; }

    public int SMTMachineId { get; set; }

    public virtual SMTLine SMTLine { get; set; } = null!;

    public virtual SMTMachine SMTMachine { get; set; } = null!;
}
