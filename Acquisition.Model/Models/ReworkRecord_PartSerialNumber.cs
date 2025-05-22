using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ReworkRecord_PartSerialNumber
{
    public int Id { get; set; }

    public int ReworkRecordId { get; set; }

    public long PartSerialNumberId { get; set; }

    public virtual PartSerialNumber PartSerialNumber { get; set; } = null!;

    public virtual ReworkRecord ReworkRecord { get; set; } = null!;
}
