using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Container
{
    /// <summary>
    /// 0:Deactive,1:Active
    /// </summary>
    public long Id { get; set; }

    public string ContainerNumber { get; set; } = null!;

    public int? MaterialId { get; set; }

    public decimal TotalQuantity { get; set; }

    public decimal Quantity { get; set; }

    public int? CurrentLocationId { get; set; }

    public string? BatchNumber { get; set; }

    public int? SupplierId { get; set; }

    public DateTime? ManufacturingDateTime { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public DateTime CreationDateTime { get; set; }

    public DateTime? PackingStartDateTime { get; set; }

    public DateTime? PackingCompleteDateTime { get; set; }

    public int? CreatorId { get; set; }

    public int? PackingUserId { get; set; }

    public decimal? MSDLifeReminingTimeInMinute { get; set; }

    /// <summary>
    /// 0 : Deactive, 1:Active, -1:QualityHold
    /// </summary>
    public int State { get; set; }

    public virtual ICollection<ContainerGenerateRecord> ContainerGenerateRecords { get; set; } = new List<ContainerGenerateRecord>();

    public virtual User? Creator { get; set; }

    public virtual Location? CurrentLocation { get; set; }

    public virtual ICollection<CustomerBoxInformation> CustomerBoxInformations { get; set; } = new List<CustomerBoxInformation>();

    public virtual Material? Material { get; set; }

    public virtual ICollection<MaterialCheckInformation> MaterialCheckInformations { get; set; } = new List<MaterialCheckInformation>();

    public virtual ICollection<MaterialPool> MaterialPools { get; set; } = new List<MaterialPool>();

    public virtual ICollection<MovementRecord> MovementRecords { get; set; } = new List<MovementRecord>();

    public virtual ICollection<PackingInformation> PackingInformations { get; set; } = new List<PackingInformation>();

    public virtual User? PackingUser { get; set; }

    public virtual ICollection<PartMaterialRecord> PartMaterialRecords { get; set; } = new List<PartMaterialRecord>();

    public virtual ICollection<SMTChangeOverTableSetup> SMTChangeOverTableSetups { get; set; } = new List<SMTChangeOverTableSetup>();

    public virtual ICollection<SMTOnlineSetup> SMTOnlineSetupContainers { get; set; } = new List<SMTOnlineSetup>();

    public virtual ICollection<SMTOnlineSetup> SMTOnlineSetupNewContainers { get; set; } = new List<SMTOnlineSetup>();

    public virtual ICollection<SetupRecord> SetupRecords { get; set; } = new List<SetupRecord>();

    public virtual Supplier? Supplier { get; set; }

    public virtual ICollection<TPMMaterialRecord> TPMMaterialRecords { get; set; } = new List<TPMMaterialRecord>();

    public virtual ICollection<WorkOrderMaterialRecord> WorkOrderMaterialRecords { get; set; } = new List<WorkOrderMaterialRecord>();
}
