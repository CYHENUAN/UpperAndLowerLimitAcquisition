using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PartMergeRecord
{
    public long Id { get; set; }

    public long MasterPartSerialNumberId { get; set; }

    public long SlavePartSerialNumberId { get; set; }

    public int MergeStationId { get; set; }

    public DateTime MergeDateTime { get; set; }

    public int? OperatorId { get; set; }

    public int? Layer { get; set; }

    public virtual PartSerialNumber MasterPartSerialNumber { get; set; } = null!;

    public virtual Station MergeStation { get; set; } = null!;

    public virtual User? Operator { get; set; }

    public virtual PartSerialNumber SlavePartSerialNumber { get; set; } = null!;
}
