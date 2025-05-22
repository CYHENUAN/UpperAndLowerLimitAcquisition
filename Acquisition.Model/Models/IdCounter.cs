using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

/// <summary>
/// Id模块的计数器
/// </summary>
public partial class IdCounter
{
    public int Id { get; set; }

    public int IdModelId { get; set; }

    public int? MaterialId { get; set; }

    public int? MaterialGroupId { get; set; }

    public int? StationId { get; set; }

    public int? CurrentCounterValue { get; set; }

    public DateTime UpdateDateTime { get; set; }

    public virtual IdModel IdModel { get; set; } = null!;

    public virtual Material? Material { get; set; }

    public virtual MaterialGroup? MaterialGroup { get; set; }

    public virtual Station? Station { get; set; }
}
