using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class CarrierBindRecord
{
    public long Id { get; set; }

    public int CarrierId { get; set; }

    public long PartSerialNumberId { get; set; }

    public int? BindType { get; set; }

    public DateTime? OperationDateTime { get; set; }

    public int? OperatorId { get; set; }

    public virtual Carrier Carrier { get; set; } = null!;

    public virtual User? Operator { get; set; }

    public virtual PartSerialNumber PartSerialNumber { get; set; } = null!;
}
