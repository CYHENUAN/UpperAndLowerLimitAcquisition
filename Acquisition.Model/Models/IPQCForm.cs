using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class IPQCForm
{
    public int Id { get; set; }

    public string IPQCFormCode { get; set; } = null!;

    public int CreatorId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int EditorId { get; set; }

    public DateTime EditDateTime { get; set; }

    public int InspectionTypeId { get; set; }

    public long PartSerialNumberId { get; set; }

    public long RecipeId { get; set; }

    public int State { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User Editor { get; set; } = null!;

    public virtual ICollection<IPQCRecord> IPQCRecords { get; set; } = new List<IPQCRecord>();

    public virtual PartSerialNumber PartSerialNumber { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;
}
