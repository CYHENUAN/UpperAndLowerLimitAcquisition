using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class CurrentToolingSetupInformation
{
    public int Id { get; set; }

    public long ToolingId { get; set; }

    public int StationId { get; set; }

    public string NestCode { get; set; } = null!;

    public DateTime SetupDateTime { get; set; }

    public int? CreatorId { get; set; }

    public virtual User? Creator { get; set; }

    public virtual Station Station { get; set; } = null!;

    public virtual Tooling Tooling { get; set; } = null!;
}
