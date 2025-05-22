using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SqueegeEventHistory
{
    public long Id { get; set; }

    public int SqueegeId { get; set; }

    /// <summary>
    /// 事件类型0:新注册,1:注册至机台,2:注册至清洗台
    /// </summary>
    public int EventTypeId { get; set; }

    public DateTime EventDateTime { get; set; }

    public int LocationId { get; set; }

    public int OperatorId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual User Operator { get; set; } = null!;

    public virtual Squeege Squeege { get; set; } = null!;
}
