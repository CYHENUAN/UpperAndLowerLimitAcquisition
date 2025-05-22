using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Material_SupplierMaterialBarcode
{
    public int Id { get; set; }

    public int MaterialId { get; set; }

    public string SupplierMaterialBarcode { get; set; } = null!;

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public int? SupplierId { get; set; }

    public virtual User? Creator { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual Supplier? Supplier { get; set; }
}
