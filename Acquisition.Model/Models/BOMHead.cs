using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class BOMHead
{
    public int Id { get; set; }

    public int MaterialId { get; set; }

    public DateTime ValidBegin { get; set; }

    public DateTime ValidEnd { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int? State { get; set; }

    public int? FactoryId { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int Version { get; set; }

    public string? ERPBOMVersion { get; set; }

    public virtual ICollection<BOMItem> BOMItems { get; set; } = new List<BOMItem>();

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual Factory? Factory { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
