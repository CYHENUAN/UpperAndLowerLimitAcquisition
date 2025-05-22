using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class StationFailure
{
    public int Id { get; set; }

    public int StationId { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }
}
