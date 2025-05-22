using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class RecipeItem
{
    public long Id { get; set; }

    public long? RecipeId { get; set; }

    public int? Sequence { get; set; }

    public string? JobCode { get; set; }

    public int? ToolId { get; set; }

    /// <summary>
    /// 参数类型, 0:字符串匹配,1:显示Value,2:显示Profile,3:显示PlainText,4:显示文件的URI
    /// </summary>
    public int? ParameterTypeId { get; set; }

    public string? ParameterName { get; set; }

    public decimal? StandardValue { get; set; }

    public decimal? USL { get; set; }

    public decimal? LSL { get; set; }

    public string? MatchString { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    /// <summary>
    /// 1:Enable,2:Disable
    /// </summary>
    public int? State { get; set; }

    public int? UnitId { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual ICollection<IPQCRecord> IPQCRecords { get; set; } = new List<IPQCRecord>();

    public virtual ICollection<IQCRecord> IQCRecords { get; set; } = new List<IQCRecord>();

    public virtual ICollection<PartMeasurementDataRecord> PartMeasurementDataRecords { get; set; } = new List<PartMeasurementDataRecord>();

    public virtual Recipe? Recipe { get; set; }
}
