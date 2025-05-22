using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTSetupListItem
{
    public int Id { get; set; }

    public int SetupId { get; set; }

    public int MachineAreaId { get; set; }

    public string MaterialLocation { get; set; } = null!;

    public int MaterialId { get; set; }

    public virtual SMTMachineArea MachineArea { get; set; } = null!;

    public virtual Material Material { get; set; } = null!;

    public virtual SMTSetup Setup { get; set; } = null!;
}
