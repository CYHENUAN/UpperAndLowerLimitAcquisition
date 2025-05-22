using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class TPMWorkOrderItemTransferRecord
{
    public int Id { get; set; }

    public int TPMWorOrderItemId { get; set; }

    public DateTime TransferDateTime { get; set; }

    public int InitiatorId { get; set; }

    public int? FromOwnerId { get; set; }

    public int ToOwnerId { get; set; }

    public string? Comment { get; set; }

    public int? TransferType { get; set; }

    public virtual User? FromOwner { get; set; }

    public virtual User Initiator { get; set; } = null!;

    public virtual TPMWorkOrderItem TPMWorOrderItem { get; set; } = null!;

    public virtual User ToOwner { get; set; } = null!;
}
