using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class IQCForm
{
    public int Id { get; set; }

    public string IQCFormCode { get; set; } = null!;

    public int CreatorId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int EditorId { get; set; }

    public DateTime EditDateTime { get; set; }

    public int InspectionTypeId { get; set; }

    public string Lot { get; set; } = null!;

    public int MaterialId { get; set; }

    public int SupplierId { get; set; }

    public long RecipeId { get; set; }

    public int state { get; set; }

    public string? OrderNumber { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User Editor { get; set; } = null!;

    public virtual ICollection<IQCRecord> IQCRecords { get; set; } = new List<IQCRecord>();

    public virtual Material Material { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
