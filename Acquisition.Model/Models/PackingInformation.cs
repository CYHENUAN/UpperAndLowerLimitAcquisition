using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PackingInformation
{
    public long Id { get; set; }

    public long ContainerId { get; set; }

    public long? SubContainerId { get; set; }

    public long? PartSerialNumberId { get; set; }

    public DateTime PackingDateTime { get; set; }

    public int CreatorId { get; set; }

    public virtual Container Container { get; set; } = null!;

    public virtual User Creator { get; set; } = null!;

    public virtual PartSerialNumber? PartSerialNumber { get; set; }
}
