using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTMachineArea
{
    public int Id { get; set; }

    public int? MachineId { get; set; }

    public string? Name { get; set; }

    public virtual SMTMachine? Machine { get; set; }

    public virtual ICollection<SMTChangeOverTable> SMTChangeOverTables { get; set; } = new List<SMTChangeOverTable>();

    public virtual ICollection<SMTOnlineSetup> SMTOnlineSetups { get; set; } = new List<SMTOnlineSetup>();

    public virtual ICollection<SMTProgramDetail> SMTProgramDetails { get; set; } = new List<SMTProgramDetail>();

    public virtual ICollection<SMTSetupListItem> SMTSetupListItems { get; set; } = new List<SMTSetupListItem>();
}
