using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PackingInformationHi
{
    public long Id { get; set; }

    public long? ContainerId { get; set; }

    public long? PartSerialNumberId { get; set; }

    public long? SubContainerId { get; set; }

    public DateTime PackingDateTime { get; set; }

    public int CreatorId { get; set; }
}
