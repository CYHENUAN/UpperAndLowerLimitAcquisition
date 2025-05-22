using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class CompanyParameter
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int MESParameterReferenceId { get; set; }

    public string ParameterValue { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual User? Editor { get; set; }

    public virtual MESParameterReference MESParameterReference { get; set; } = null!;
}
