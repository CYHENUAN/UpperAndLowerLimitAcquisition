using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialPool
{
    public long Id { get; set; }

    public string? SetupName { get; set; }

    public long ContainerId { get; set; }

    public int StationId { get; set; }

    /// <summary>
    /// SMTFeeder的位置号
    /// </summary>
    public string? FeederLocation { get; set; }

    public string? Designator { get; set; }

    /// <summary>
    /// 0:TOP,1:BOT,2:Indepent
    /// </summary>
    public int? Layer { get; set; }

    public DateTime SetupDateTime { get; set; }

    public int? SetupOperatorId { get; set; }

    public bool? IsAlternative { get; set; }

    public int ControlState { get; set; }

    public virtual Container Container { get; set; } = null!;

    public virtual User? SetupOperator { get; set; }

    public virtual Station Station { get; set; } = null!;
}
