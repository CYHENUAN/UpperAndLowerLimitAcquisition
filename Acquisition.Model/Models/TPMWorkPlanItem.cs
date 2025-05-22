using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class TPMWorkPlanItem
{
    public int Id { get; set; }

    public int TPMWorkPlanId { get; set; }

    public string Name { get; set; } = null!;

    public string Designator { get; set; } = null!;

    public int? MaterialId { get; set; }

    public int MaintenanceItemId { get; set; }

    public string? Comment { get; set; }

    public int? EdocumentId { get; set; }

    public double WorkingHour { get; set; }

    public int? DefaultMaintenanceRoleId { get; set; }

    /// <summary>
    /// 1:Required,0:NoNeed
    /// </summary>
    public int? RequireMeasure { get; set; }

    /// <summary>
    /// 1:ValueRange,2:SpecificNormalValue,3:ProfileData
    /// </summary>
    public int? MeasurementType { get; set; }

    public int? UnitId { get; set; }

    public double? Normal { get; set; }

    public double? USL { get; set; }

    public double? LSL { get; set; }

    public string? ProfileSampleData { get; set; }

    /// <summary>
    /// 1:Mandatory,2:Optional
    /// </summary>
    public int? IsMandatory { get; set; }

    public virtual Role? DefaultMaintenanceRole { get; set; }

    public virtual EDocument? Edocument { get; set; }

    public virtual MaintenanceItem MaintenanceItem { get; set; } = null!;

    public virtual Material? Material { get; set; }

    public virtual TPMWorkPlan TPMWorkPlan { get; set; } = null!;

    public virtual Unit? Unit { get; set; }
}
