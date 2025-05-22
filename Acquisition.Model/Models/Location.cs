using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Location
{
    public int Id { get; set; }

    public string LocationNumber { get; set; } = null!;

    public string? Description { get; set; }

    public int? AreaId { get; set; }

    public double? X { get; set; }

    public double? Y { get; set; }

    public double? Z { get; set; }

    public int? State { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    /// <summary>
    /// 0: 实体库位(比如货架)1:虚拟库, 2:, 3:ECALL线体
    /// </summary>
    public int? Type { get; set; }

    public virtual Area? Area { get; set; }

    public virtual ICollection<ContainerGenerateRecord> ContainerGenerateRecords { get; set; } = new List<ContainerGenerateRecord>();

    public virtual ICollection<Container> Containers { get; set; } = new List<Container>();

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual ICollection<JPH> JPHs { get; set; } = new List<JPH>();

    public virtual ICollection<MaterialCheckBillFormItem> MaterialCheckBillFormItems { get; set; } = new List<MaterialCheckBillFormItem>();

    public virtual ICollection<MaterialCheckInformation> MaterialCheckInformations { get; set; } = new List<MaterialCheckInformation>();

    public virtual ICollection<Material> MaterialDefaultStorageLocations { get; set; } = new List<Material>();

    public virtual ICollection<Material> MaterialDefaultTargetFeedingLocations { get; set; } = new List<Material>();

    public virtual ICollection<MaterialPickingFormItem> MaterialPickingFormItems { get; set; } = new List<MaterialPickingFormItem>();

    public virtual ICollection<MaterialPickingForm> MaterialPickingForms { get; set; } = new List<MaterialPickingForm>();

    public virtual ICollection<MaterialReceivingFormItem> MaterialReceivingFormItems { get; set; } = new List<MaterialReceivingFormItem>();

    public virtual ICollection<MaterialRequestFormItem> MaterialRequestFormItems { get; set; } = new List<MaterialRequestFormItem>();

    public virtual ICollection<MaterialRequestForm> MaterialRequestForms { get; set; } = new List<MaterialRequestForm>();

    public virtual ICollection<MovementRecord> MovementRecordDestinationLocations { get; set; } = new List<MovementRecord>();

    public virtual ICollection<MovementRecord> MovementRecordSourceLocations { get; set; } = new List<MovementRecord>();

    public virtual ICollection<ProductInStockingFormItem> ProductInStockingFormItemSourceLocations { get; set; } = new List<ProductInStockingFormItem>();

    public virtual ICollection<ProductInStockingFormItem> ProductInStockingFormItemTargetLocations { get; set; } = new List<ProductInStockingFormItem>();

    public virtual ICollection<ReplenishLocation_Station> ReplenishLocation_Stations { get; set; } = new List<ReplenishLocation_Station>();

    public virtual ICollection<SolderPasteEventHistory> SolderPasteEventHistories { get; set; } = new List<SolderPasteEventHistory>();

    public virtual ICollection<SqueegeEventHistory> SqueegeEventHistories { get; set; } = new List<SqueegeEventHistory>();

    public virtual ICollection<Tooling> Toolings { get; set; } = new List<Tooling>();

    public virtual ICollection<WMSWorkOrder> WMSWorkOrders { get; set; } = new List<WMSWorkOrder>();
}
