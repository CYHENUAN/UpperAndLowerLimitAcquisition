using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ProductModel
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public int? ProductModelId { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual Material? ProductModelNavigation { get; set; }
}
