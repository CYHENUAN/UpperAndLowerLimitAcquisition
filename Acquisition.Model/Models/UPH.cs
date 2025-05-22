using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class UPH
{
    public int Id { get; set; }

    public int CellId { get; set; }

    public int MaterialId { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    /// <summary>
    /// 1:Active, 0:Deactive
    /// </summary>
    public int State { get; set; }

    public decimal? value { get; set; }

    public virtual Cell Cell { get; set; } = null!;
}
