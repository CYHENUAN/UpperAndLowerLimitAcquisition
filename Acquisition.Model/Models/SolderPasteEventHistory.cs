using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SolderPasteEventHistory
{
    public long Id { get; set; }

    public int SolderPasteId { get; set; }

    /// <summary>
    /// 锡膏事件类型:0:收货,1:注册到冰箱,2:注册到回温区,3:注册到机台
    /// </summary>
    public int EventTypeId { get; set; }

    public DateTime EventDateTime { get; set; }

    public int LocationId { get; set; }

    public int OperatorId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual User Operator { get; set; } = null!;
}
