using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class IdModelAssignment
{
    public int Id { get; set; }

    public int IdModelId { get; set; }

    /// <summary>
    /// 1:MaterialGroup,2:Material
    ///   如果IdModel同时分配给Material和MaterialGroup，Material的IdModel优先。
    /// </summary>
    public int EntityType { get; set; }

    /// <summary>
    /// Material或者MaterialGroup的EntityId
    /// </summary>
    public int EntityId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public virtual IdModel IdModel { get; set; } = null!;
}
