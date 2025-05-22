using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class IQCRecord
{
    public int Id { get; set; }

    public int IQCFormId { get; set; }

    public long RecipeItemId { get; set; }

    public decimal? Value { get; set; }

    public string? ProfileValues { get; set; }

    public string? PlainText { get; set; }

    public string? DataFileURI { get; set; }

    public int EditorId { get; set; }

    public DateTime RecordDateTime { get; set; }

    /// <summary>
    /// 0:未测试,1:检验中,2:PASS,3:FAIL
    /// </summary>
    public int State { get; set; }

    public int Times { get; set; }

    public virtual User Editor { get; set; } = null!;

    public virtual IQCForm IQCForm { get; set; } = null!;

    public virtual RecipeItem RecipeItem { get; set; } = null!;
}
