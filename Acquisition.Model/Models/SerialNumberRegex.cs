using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SerialNumberRegex
{
    public int Id { get; set; }

    public int ProductMaterialId { get; set; }

    public string? CustomerName { get; set; }

    public string? ProductFamily { get; set; }

    public string RegexExpression { get; set; } = null!;

    public int State { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? Type { get; set; }

    public virtual User? Editor { get; set; }

    public virtual Material ProductMaterial { get; set; } = null!;
}
