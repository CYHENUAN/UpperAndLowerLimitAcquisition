using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class LockUnlockPartSNRecord
{
    /// <summary>
    /// 1:立即锁定,2:未来锁定,0:解锁
    /// </summary>
    public int Id { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int CreatorId { get; set; }

    public long WorkOrderId { get; set; }

    /// <summary>
    /// 1:锁定,2:解锁
    /// </summary>
    public bool LockOrUnLock { get; set; }

    /// <summary>
    /// 1:Lock immediately, 2:Lock in future
    /// </summary>
    public int LockType { get; set; }

    public int? FutureLockProcessStepId { get; set; }

    public string? Comment { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual ICollection<LockUnlockPartSNRecord_PartSerialNumber> LockUnlockPartSNRecord_PartSerialNumbers { get; set; } = new List<LockUnlockPartSNRecord_PartSerialNumber>();

    public virtual WorkOrder WorkOrder { get; set; } = null!;
}
