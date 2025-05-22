using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PartMaterialRecord
{
    public long Id { get; set; }

    public long PartSerialNumberId { get; set; }

    public long MaterialContainerId { get; set; }

    public int MaterialSetupStationId { get; set; }

    public DateTime MaterialSetupDateTime { get; set; }

    public DateTime MaterialInstallDateTime { get; set; }

    public int MaterialSetupOperatorId { get; set; }

    public string? Designator { get; set; }

    public int? Layer { get; set; }

    public string? FeederLocation { get; set; }

    public decimal? ConsumedQuantity { get; set; }

    public int ProcessStepId { get; set; }

    public DateTime? ArchiveDateTime { get; set; }

    public virtual Container MaterialContainer { get; set; } = null!;

    public virtual User MaterialSetupOperator { get; set; } = null!;

    public virtual Station MaterialSetupStation { get; set; } = null!;

    public virtual PartSerialNumber PartSerialNumber { get; set; } = null!;

    public virtual ProcessStep ProcessStep { get; set; } = null!;
}
