using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PartProcessOperationStepRecord
{
    public long Id { get; set; }

    public long? PartProcessRecordId { get; set; }

    public int? OperationStepld { get; set; }

    public int? State { get; set; }

    public virtual OperationStep? OperationStepldNavigation { get; set; }

    public virtual PartProcessRecord? PartProcessRecord { get; set; }
}
