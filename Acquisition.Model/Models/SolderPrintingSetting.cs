using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SolderPrintingSetting
{
    public int Id { get; set; }

    public string ParameterCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ValueType { get; set; } = null!;

    public string Value { get; set; } = null!;

    public int CreatorId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public virtual User Creator { get; set; } = null!;

    public virtual User? Editor { get; set; }
}
