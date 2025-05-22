using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Carrier
{
    public int Id { get; set; }

    public string CarrierNumber { get; set; } = null!;

    public long? CurrentPartId { get; set; }

    public int? CreatorId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public DateTime? UpdateDateTime { get; set; }

    public int? EditorId { get; set; }

    public virtual ICollection<CarrierBindRecord> CarrierBindRecords { get; set; } = new List<CarrierBindRecord>();

    public virtual User? Creator { get; set; }

    public virtual PartSerialNumber? CurrentPart { get; set; }

    public virtual User? Editor { get; set; }
}
