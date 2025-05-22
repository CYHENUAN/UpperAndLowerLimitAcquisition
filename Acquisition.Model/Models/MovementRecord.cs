using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MovementRecord
{
    public long Id { get; set; }

    public long ContainerId { get; set; }

    public int SourceLocationId { get; set; }

    public int DestinationLocationId { get; set; }

    public int OperationFormTypeId { get; set; }

    public DateTime OperationDateTime { get; set; }

    public int OperatorId { get; set; }

    public int? OperationFormId { get; set; }

    public int? OperationFormItemNumber { get; set; }

    public decimal? MoveQuantity { get; set; }

    public virtual Container Container { get; set; } = null!;

    public virtual Location DestinationLocation { get; set; } = null!;

    public virtual WMSForm? OperationForm { get; set; }

    public virtual FormType OperationFormType { get; set; } = null!;

    public virtual User Operator { get; set; } = null!;

    public virtual Location SourceLocation { get; set; } = null!;
}
