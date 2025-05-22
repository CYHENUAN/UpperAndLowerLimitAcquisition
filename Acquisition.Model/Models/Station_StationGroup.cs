using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Station_StationGroup
{
    public int Id { get; set; }

    public int StationId { get; set; }

    public int StationGroupId { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public virtual User? Editor { get; set; }

    public virtual Station Station { get; set; } = null!;

    public virtual StationGroup StationGroup { get; set; } = null!;
}
