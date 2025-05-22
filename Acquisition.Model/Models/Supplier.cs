using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string SupplierCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? DUNS { get; set; }

    public string? Country { get; set; }

    public string? Province { get; set; }

    public string? Address { get; set; }

    public string? PostCode { get; set; }

    public string? Fax { get; set; }

    public string? ContactPerson { get; set; }

    public string? Email { get; set; }

    public string? Telphone { get; set; }

    public string? MobilePhone { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? State { get; set; }

    public virtual ICollection<Container> Containers { get; set; } = new List<Container>();

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual ICollection<IQCForm> IQCForms { get; set; } = new List<IQCForm>();

    public virtual ICollection<Machine> Machines { get; set; } = new List<Machine>();

    public virtual ICollection<MaterialReceivingFormItem> MaterialReceivingFormItems { get; set; } = new List<MaterialReceivingFormItem>();

    public virtual ICollection<MaterialReturnForm> MaterialReturnForms { get; set; } = new List<MaterialReturnForm>();

    public virtual ICollection<Material_SupplierMaterialBarcode> Material_SupplierMaterialBarcodes { get; set; } = new List<Material_SupplierMaterialBarcode>();

    public virtual ICollection<Tooling> Toolings { get; set; } = new List<Tooling>();
}
