using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

/// <summary>
/// 序列号计数器
/// </summary>
public partial class SNCounter
{
    public long Id { get; set; }

    /// <summary>
    /// 1:Raw Material Container SN, 2: Part SN, 3:Virtual Final Product SN,4:Customer SN
    /// </summary>
    public int? TypeId { get; set; }

    public string? WorkOrderNumber { get; set; }

    public string? MaterialNumber { get; set; }

    public int? Counter { get; set; }
}
