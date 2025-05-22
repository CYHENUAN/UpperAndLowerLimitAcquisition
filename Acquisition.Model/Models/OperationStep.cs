using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

/// <summary>
/// 工艺步骤的工步
/// </summary>
public partial class OperationStep
{
    public int Id { get; set; }

    public int Secquence { get; set; }

    public string StepCode { get; set; } = null!;

    public int ProcessStepId { get; set; }

    public long? ToolingId { get; set; }

    public string Name { get; set; } = null!;

    /// <summary>
    /// 螺丝孔号/测量项名， 与RecipeItem.Name关联
    /// </summary>
    public string? ParameterName { get; set; }

    public string? ParameterValue { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int? State { get; set; }

    /// <summary>
    /// 调用控制器/PLC的程序/命令代号
    /// </summary>
    public int? ProgramId { get; set; }

    /// <summary>
    /// 工步类型：1:手工,2:自动拧紧,3:气密测试,4:压装,5:涂胶,6:视觉检测
    /// </summary>
    public int? StepType { get; set; }

    /// <summary>
    /// 工步所控制的控制器，比如拧紧控制器1
    /// </summary>
    public string? Controller { get; set; }

    /// <summary>
    /// 1:PLC,2:拧紧控制器,3:气密仪,4:压机
    /// </summary>
    public int? ControllerType { get; set; }

    public string? ParameterConfigJson { get; set; }

    /// <summary>
    /// 都为同一个值的话，就代表多线程同时做的，对应到PLC的TaskId，例如：4个枪同时打，都是同一个ThreadId
    /// </summary>
    public int? ThreadId { get; set; }

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual ICollection<PartProcessOperationStepRecord> PartProcessOperationStepRecords { get; set; } = new List<PartProcessOperationStepRecord>();

    public virtual Tooling? Tooling { get; set; }
}
