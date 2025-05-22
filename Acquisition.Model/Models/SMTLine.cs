using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTLine
{
    public int Id { get; set; }

    public string LineCode { get; set; } = null!;

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public virtual ICollection<SMTLine_SMTMachine> SMTLine_SMTMachines { get; set; } = new List<SMTLine_SMTMachine>();

    public virtual ICollection<SMTOnlineProgram> SMTOnlinePrograms { get; set; } = new List<SMTOnlineProgram>();

    public virtual ICollection<SMTOnlineSetup> SMTOnlineSetups { get; set; } = new List<SMTOnlineSetup>();

    public virtual ICollection<SMTProgram> SMTPrograms { get; set; } = new List<SMTProgram>();
}
