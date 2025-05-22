using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EventProcessChangeDetail
{
    public long Id { get; set; }

    public long? EventProcessLogId { get; set; }

    public string? Property { get; set; }

    public string? OriginalValue { get; set; }

    public string? FinalValue { get; set; }

    public virtual EventProcessChangeLog? EventProcessLog { get; set; }
}
