using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MachineMessageLog
{
    public long Id { get; set; }

    public int MachineId { get; set; }

    public int MessageTypeId { get; set; }

    public string? Commemt { get; set; }

    public DateTime LogDateTime { get; set; }

    public virtual Machine Machine { get; set; } = null!;

    public virtual MessageType MessageType { get; set; } = null!;
}
