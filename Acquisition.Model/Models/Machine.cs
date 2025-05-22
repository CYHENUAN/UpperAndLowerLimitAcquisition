using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Machine
{
    public int Id { get; set; }

    public string MachineCode { get; set; } = null!;

    public string? Name { get; set; }

    public int? StationId { get; set; }

    public int? SupplierId { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public DateOnly? ManufacturingDate { get; set; }

    public DateOnly? InstalledDate { get; set; }

    public int? State { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public string? CurrentPartSerialNumber { get; set; }

    public string? LastPartSerialNumber { get; set; }

    public DateTime? CurrentPartInputDateTime { get; set; }

    public DateTime? LastPartOutputDateTime { get; set; }

    public string? CurrentPartType { get; set; }

    public string? CurrentPartCode { get; set; }

    public decimal? LastPartCycleTime { get; set; }

    public string? RoutingCode { get; set; }

    public string? IPV4Address { get; set; }

    public string? CurrentJobName { get; set; }

    public string? CurrentJobCode { get; set; }

    public string? OperatorCode { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual ICollection<MSATest> MSATests { get; set; } = new List<MSATest>();

    public virtual ICollection<MachineCurrentToolingSetupDatum> MachineCurrentToolingSetupData { get; set; } = new List<MachineCurrentToolingSetupDatum>();

    public virtual ICollection<MachineMessageLog> MachineMessageLogs { get; set; } = new List<MachineMessageLog>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual Station? Station { get; set; }

    public virtual Supplier? Supplier { get; set; }

    public virtual ICollection<TPMWorkPlan> TPMWorkPlans { get; set; } = new List<TPMWorkPlan>();
}
