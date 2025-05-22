using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ERPWorkOrderHi
{
    public long Id { get; set; }

    /// <summary>
    /// 工厂
    /// </summary>
    public string WERKS { get; set; } = null!;

    /// <summary>
    /// 生产订单号
    /// </summary>
    public string AUFNR { get; set; } = null!;

    /// <summary>
    /// 订单类型
    /// </summary>
    public string AUART { get; set; } = null!;

    /// <summary>
    /// 物料
    /// </summary>
    public string MATNR { get; set; } = null!;

    /// <summary>
    /// 物料描述
    /// </summary>
    public string MAKTX { get; set; } = null!;

    public decimal PSMNG { get; set; }

    public string MEINS { get; set; } = null!;

    /// <summary>
    /// 基本开始日期
    /// </summary>
    public DateTime GSTRP { get; set; }

    /// <summary>
    /// 基本结束日期
    /// </summary>
    public DateTime GLTRS { get; set; }

    public string ERNAM { get; set; } = null!;

    public string FTRMI { get; set; } = null!;

    /// <summary>
    /// 消息类型
    /// </summary>
    public string RESULTSTATUS { get; set; } = null!;

    /// <summary>
    /// 消息文本
    /// </summary>
    public string? RESULTMSG { get; set; }

    public DateTime? creationDatetime { get; set; }
}
