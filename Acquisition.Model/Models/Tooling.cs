using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

/// <summary>
/// 工装夹具
/// </summary>
public partial class Tooling
{
    public long Id { get; set; }

    public string ToolingCode { get; set; } = null!;

    public int? ToolingTypeId { get; set; }

    public int? SupplierId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? CurrentLocationId { get; set; }

    public int State { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual Location? CurrentLocation { get; set; }

    public virtual ICollection<CurrentToolingSetupInformation> CurrentToolingSetupInformations { get; set; } = new List<CurrentToolingSetupInformation>();

    public virtual User? Editor { get; set; }

    public virtual ICollection<MachineCurrentToolingSetupDatum> MachineCurrentToolingSetupData { get; set; } = new List<MachineCurrentToolingSetupDatum>();

    public virtual ICollection<OperationStep> OperationSteps { get; set; } = new List<OperationStep>();

    public virtual Supplier? Supplier { get; set; }

    public virtual ICollection<ToolingLife> ToolingLives { get; set; } = new List<ToolingLife>();

    public virtual ToolingType? ToolingType { get; set; }
}
