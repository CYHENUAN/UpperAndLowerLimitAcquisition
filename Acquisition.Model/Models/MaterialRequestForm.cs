using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class MaterialRequestForm
{
    public int Id { get; set; }

    public string MaterialRequestFormNumber { get; set; } = null!;

    public int RequestLocationId { get; set; }

    public int PickingAreaId { get; set; }

    public DateTime? RequiredOnBoardDateTime { get; set; }

    public int CreatorId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    /// <summary>
    /// -1:撤销,1:新,2配货种:,3:已配货,
    /// </summary>
    public int State { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual ICollection<MaterialRequestFormItem> MaterialRequestFormItems { get; set; } = new List<MaterialRequestFormItem>();

    public virtual Area PickingArea { get; set; } = null!;

    public virtual Location RequestLocation { get; set; } = null!;
}
