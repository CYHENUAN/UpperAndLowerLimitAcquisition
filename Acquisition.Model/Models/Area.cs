using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Area
{
    public int Id { get; set; }

    public string AreaNumber { get; set; } = null!;

    public string? Description { get; set; }

    public int FactoryId { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public string Name { get; set; } = null!;

    /// <summary>
    /// 0：virtual ，1：WareHouse，2：Department
    /// </summary>
    public int? AreaType { get; set; }

    public int State { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Factory Factory { get; set; } = null!;

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<MaterialCheckBillForm> MaterialCheckBillForms { get; set; } = new List<MaterialCheckBillForm>();

    public virtual ICollection<MaterialOtherMovementFormItem> MaterialOtherMovementFormItemSourceAreas { get; set; } = new List<MaterialOtherMovementFormItem>();

    public virtual ICollection<MaterialOtherMovementFormItem> MaterialOtherMovementFormItemSupplierAreas { get; set; } = new List<MaterialOtherMovementFormItem>();

    public virtual ICollection<MaterialOtherMovementFormItem> MaterialOtherMovementFormItemTargetAreas { get; set; } = new List<MaterialOtherMovementFormItem>();

    public virtual ICollection<MaterialPickingFormItem> MaterialPickingFormItems { get; set; } = new List<MaterialPickingFormItem>();

    public virtual ICollection<MaterialPickingForm> MaterialPickingForms { get; set; } = new List<MaterialPickingForm>();

    public virtual ICollection<MaterialRequestForm> MaterialRequestForms { get; set; } = new List<MaterialRequestForm>();

    public virtual ICollection<ProductDeliveryRequestForm> ProductDeliveryRequestForms { get; set; } = new List<ProductDeliveryRequestForm>();

    public virtual ICollection<Role_Area> Role_Areas { get; set; } = new List<Role_Area>();
}
