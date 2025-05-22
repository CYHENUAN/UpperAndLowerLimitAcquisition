using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class WMSForm
{
    public int Id { get; set; }

    public string FormNumber { get; set; } = null!;

    public int FormTypeId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int? State { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual FormType FormType { get; set; } = null!;

    public virtual ICollection<MaterialCheckBillForm> MaterialCheckBillForms { get; set; } = new List<MaterialCheckBillForm>();

    public virtual ICollection<MaterialOtherMovementForm> MaterialOtherMovementForms { get; set; } = new List<MaterialOtherMovementForm>();

    public virtual ICollection<MaterialPickingForm> MaterialPickingForms { get; set; } = new List<MaterialPickingForm>();

    public virtual ICollection<MaterialReceivingForm> MaterialReceivingForms { get; set; } = new List<MaterialReceivingForm>();

    public virtual ICollection<MaterialReturnForm> MaterialReturnForms { get; set; } = new List<MaterialReturnForm>();

    public virtual ICollection<MovementRecord> MovementRecords { get; set; } = new List<MovementRecord>();

    public virtual ICollection<ProductDeliveryRequestForm> ProductDeliveryRequestForms { get; set; } = new List<ProductDeliveryRequestForm>();

    public virtual ICollection<ProductInStockingForm> ProductInStockingForms { get; set; } = new List<ProductInStockingForm>();
}
