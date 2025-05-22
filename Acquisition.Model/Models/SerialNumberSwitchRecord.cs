using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SerialNumberSwitchRecord
{
    public long Id { get; set; }

    public long PartSerialNumberId { get; set; }

    public string OldSerialNumber { get; set; } = null!;

    public string NewSerialNumber { get; set; } = null!;

    public DateTime SwitchDateTime { get; set; }

    public int EditorId { get; set; }

    public virtual User Editor { get; set; } = null!;

    public virtual PartSerialNumber PartSerialNumber { get; set; } = null!;
}
