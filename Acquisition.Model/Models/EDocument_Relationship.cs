using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EDocument_Relationship
{
    public int Id { get; set; }

    public int EDocumentId { get; set; }

    public int? StationGroupId { get; set; }

    public int? MaterialId { get; set; }

    public long? WorkOrderId { get; set; }

    public int? StationId { get; set; }

    public int? CellId { get; set; }

    public int? ProcessStepId { get; set; }

    public int? Layer { get; set; }

    public int State { get; set; }

    public virtual Cell? Cell { get; set; }

    public virtual EDocument EDocument { get; set; } = null!;

    public virtual Material? Material { get; set; }

    public virtual ProcessStep? ProcessStep { get; set; }

    public virtual Station? Station { get; set; }

    public virtual StationGroup? StationGroup { get; set; }

    public virtual WorkOrder? WorkOrder { get; set; }
}
