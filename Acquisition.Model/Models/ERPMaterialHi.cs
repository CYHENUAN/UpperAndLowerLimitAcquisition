using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ERPMaterialHi
{
    public long Id { get; set; }

    public string MaterialNumber { get; set; } = null!;

    public int Version { get; set; }

    public string Description { get; set; } = null!;

    public string Specification { get; set; } = null!;

    public string RESULTSTATUS { get; set; } = null!;

    public string? RESULTMSG { get; set; }

    public DateTime? creationDatetime { get; set; }
}
