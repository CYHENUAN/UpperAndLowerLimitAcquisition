using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class LockUnlockPartSNRecord_PartSerialNumber
{
    public int Id { get; set; }

    public int LockUnlockPartSNRecordId { get; set; }

    public long PartSerialNumberId { get; set; }

    public virtual LockUnlockPartSNRecord LockUnlockPartSNRecord { get; set; } = null!;

    public virtual PartSerialNumber PartSerialNumber { get; set; } = null!;
}
