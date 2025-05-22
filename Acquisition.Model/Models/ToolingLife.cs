using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ToolingLife
{
    public long Id { get; set; }

    public long ToolingId { get; set; }

    public int ToolingLifeCheckRuleId { get; set; }

    public decimal CurrentLifeConsumedValue { get; set; }

    public virtual Tooling Tooling { get; set; } = null!;

    public virtual ToolingLifeCheckRule ToolingLifeCheckRule { get; set; } = null!;
}
