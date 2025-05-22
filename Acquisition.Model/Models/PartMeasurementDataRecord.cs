using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PartMeasurementDataRecord
{
    public long Id { get; set; }

    public long PartProcessRecordId { get; set; }

    /// <summary>
    /// 如果没有Recipe,Recipe,根据系统参数设定,可以报错, 也可以直接新建一个Recipe和RecipeItem
    /// </summary>
    public long RecipeItemId { get; set; }

    public decimal? Value { get; set; }

    public decimal? AVGValue { get; set; }

    public decimal? MEANValue { get; set; }

    public decimal? MAXValue { get; set; }

    public decimal? MINValue { get; set; }

    public string? ProfileValues { get; set; }

    public string? PlainText { get; set; }

    public string? DataFileURI { get; set; }

    /// <summary>
    /// 0:OK,1:FAIL,2:SCRAP
    /// </summary>
    public int? State { get; set; }

    public DateTime? ArchiveDateTime { get; set; }

    public virtual PartProcessRecord PartProcessRecord { get; set; } = null!;

    public virtual RecipeItem RecipeItem { get; set; } = null!;
}
