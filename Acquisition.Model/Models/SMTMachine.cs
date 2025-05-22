using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTMachine
{
    public int Id { get; set; }

    public string MachineCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public string? SerialNumber { get; set; }

    public int? ConveyorType { get; set; }

    public int? TotalSides { get; set; }

    public int? TotalTables { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public virtual User? Creator { get; set; }

    public virtual ICollection<SMTLine_SMTMachine> SMTLine_SMTMachines { get; set; } = new List<SMTLine_SMTMachine>();

    public virtual ICollection<SMTMachineArea> SMTMachineAreas { get; set; } = new List<SMTMachineArea>();
}
