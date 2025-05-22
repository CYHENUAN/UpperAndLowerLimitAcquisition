using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialQueue
{
    public long Id { get; set; }

    /// <summary>
    /// 对应的是Cell表的CellNumber
    /// </summary>
    public string? LineCode { get; set; }

    public int? NestNumber { get; set; }

    public string? MaterialNumber { get; set; }

    public string? VariantCode { get; set; }

    public string? MaterialContainerNumber { get; set; }

    public DateTime? MaterialSetupDateTime { get; set; }

    public DateTime? MarkedDateTime { get; set; }

    /// <summary>
    /// -1:还未打标,0:打标OK,1:打标Fail
    /// </summary>
    public int? MarkedResult { get; set; }

    public string? MarkedSN { get; set; }
}
