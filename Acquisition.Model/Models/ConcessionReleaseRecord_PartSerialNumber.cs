using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ConcessionReleaseRecord_PartSerialNumber
{
    public int Id { get; set; }

    public int ConcessionReleaseRecordId { get; set; }

    public long PartSerialNumberId { get; set; }

    public virtual ConcessionReleaseRecord ConcessionReleaseRecord { get; set; } = null!;

    public virtual PartSerialNumber PartSerialNumber { get; set; } = null!;
}
