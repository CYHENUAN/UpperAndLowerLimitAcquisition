using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class TPMWorkOrderItem
{
    public int Id { get; set; }

    public int TPMWorkOrderId { get; set; }

    public int Sequence { get; set; }

    public string Designator { get; set; } = null!;

    public int? MaterialId { get; set; }

    public int? MaintenanceItemId { get; set; }

    public string? Comment { get; set; }

    public int? EdocumentId { get; set; }

    public double? WorkingHour { get; set; }

    public int? DefaultMaintenanceRoleId { get; set; }

    public int RequireMeasure { get; set; }

    public int? MeasurementType { get; set; }

    public int? UnitId { get; set; }

    public double? Normal { get; set; }

    public double? USL { get; set; }

    public double? LSL { get; set; }

    public string? ProfileSampleData { get; set; }

    public int? IsMandatory { get; set; }

    public int? ActionOwerId { get; set; }

    public int? Status { get; set; }

    public virtual User? ActionOwer { get; set; }

    public virtual Role? DefaultMaintenanceRole { get; set; }

    public virtual EDocument? Edocument { get; set; }

    public virtual MaintenanceItem? MaintenanceItem { get; set; }

    public virtual Material? Material { get; set; }

    public virtual TPMWorkOrder TPMWorkOrder { get; set; } = null!;

    public virtual ICollection<TPMWorkOrderItemTransferRecord> TPMWorkOrderItemTransferRecords { get; set; } = new List<TPMWorkOrderItemTransferRecord>();

    public virtual ICollection<TPMWorkRecord> TPMWorkRecords { get; set; } = new List<TPMWorkRecord>();
}
