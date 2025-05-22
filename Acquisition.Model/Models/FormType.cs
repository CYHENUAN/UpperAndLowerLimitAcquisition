using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class FormType
{
    public int Id { get; set; }

    public string? FormTypeCode { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    /// <summary>
    /// 1:Active,0:Deactive
    /// </summary>
    public int State { get; set; }

    /// <summary>
    /// 是否有表单
    /// </summary>
    public bool HasForm { get; set; }

    public bool NeedScanLocation { get; set; }

    public bool NeedCustomerBoxNumber { get; set; }

    public virtual ICollection<ContainerGenerateRecord> ContainerGenerateRecords { get; set; } = new List<ContainerGenerateRecord>();

    public virtual ICollection<MovementRecord> MovementRecords { get; set; } = new List<MovementRecord>();

    public virtual ICollection<WMSForm> WMSForms { get; set; } = new List<WMSForm>();
}
