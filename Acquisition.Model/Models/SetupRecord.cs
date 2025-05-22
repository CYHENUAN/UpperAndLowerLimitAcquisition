using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SetupRecord
{
    public long Id { get; set; }

    public int StationId { get; set; }

    /// <summary>
    /// 可以填入PDA的序列号，用来找到某个设备扫码的
    /// </summary>
    public string? Device { get; set; }

    /// <summary>
    /// 某个设备的某个供料器代号
    /// </summary>
    public string? Feeder { get; set; }

    /// <summary>
    /// 某个总成中的某个BOMItem的唯一Designator物料位置号
    /// </summary>
    public string? Designator { get; set; }

    /// <summary>
    /// 上料，下料，接料时间
    /// </summary>
    public DateTime SetupDateTime { get; set; }

    /// <summary>
    /// 扫描到的内容
    /// </summary>
    public string ScannedContent { get; set; } = null!;

    /// <summary>
    /// 数量
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// 批次号
    /// </summary>
    public string? BatchNumber { get; set; }

    /// <summary>
    /// ContainerId
    /// </summary>
    public long? ContainerId { get; set; }

    /// <summary>
    /// 上料类型：1：上料，2：下料，3：接料
    /// </summary>
    public int? SetupType { get; set; }

    /// <summary>
    /// 1：成功，2：失败
    /// </summary>
    public int SetupResult { get; set; }

    /// <summary>
    /// 上料员工Id
    /// </summary>
    public int? OperatorId { get; set; }

    public virtual Container? Container { get; set; }

    public virtual User? Operator { get; set; }

    public virtual Station Station { get; set; } = null!;
}
