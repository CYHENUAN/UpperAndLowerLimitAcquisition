using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class AGVDataConfig
{
    public int Id { get; set; }

    /// <summary>
    /// MES工位号
    /// </summary>
    public string StationNumber { get; set; } = null!;

    /// <summary>
    /// AGV的工位点位
    /// </summary>
    public string AGVSite { get; set; } = null!;

    /// <summary>
    /// 物料编号
    /// </summary>
    public string? MaterialNumber { get; set; }

    /// <summary>
    /// 物料名称
    /// </summary>
    public string? MaterialName { get; set; }

    public bool Single { get; set; }

    public string? Description { get; set; }
}
