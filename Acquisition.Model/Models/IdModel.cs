using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class IdModel
{
    public int Id { get; set; }

    public string ModelName { get; set; } = null!;

    public DateTime CreationDateTime { get; set; }

    public int CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    /// <summary>
    /// 0:Deactive, 1:Active
    /// </summary>
    public int State { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    /// <summary>
    /// 1:Dec,2:Hex,3:Alphanumerical
    /// </summary>
    public int CounterIdFormatType { get; set; }

    /// <summary>
    /// 都换算为10进制后填写
    /// </summary>
    public int CounterFrom { get; set; }

    /// <summary>
    /// 都换算为10进制后填写
    /// </summary>
    public int CounterTo { get; set; }

    public int Increment { get; set; }

    /// <summary>
    /// 1:Joint(所有物料，物料组用共用一个Counter，可按Station区分),2:Material(一种物料一个Counter,如果IsStationRelated=True的情况下，每个工站再区分Counter),3:MaterialGroup(一个MaterialGroup共享一个Conter,如果IsStationRelated是True的情况，通过Station区分)
    /// 如果IdModel分配给PartGroup，然后这里CounterManagementType是Material的话，Counter会按Material区分开，如果还有Station的话也再进行区分。
    /// </summary>
    public int CounterManagementType { get; set; }

    /// <summary>
    /// 0:Never,1:Daily,2:Weekly,3:Monthly,4:Yearly,5:WorkOrder,6:Shift
    /// </summary>
    public int ResetCounterType { get; set; }

    public bool IsStationRelated { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual ICollection<IdCounter> IdCounters { get; set; } = new List<IdCounter>();

    public virtual ICollection<IdLayout> IdLayouts { get; set; } = new List<IdLayout>();

    public virtual ICollection<IdModelAssignment> IdModelAssignments { get; set; } = new List<IdModelAssignment>();
}
