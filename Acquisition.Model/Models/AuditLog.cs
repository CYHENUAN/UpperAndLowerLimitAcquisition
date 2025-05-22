using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class AuditLog
{
    public int LogID { get; set; }

    public int PlatfromID { get; set; }

    public string? ServiceName { get; set; }

    public string? MethodName { get; set; }

    public string? Parameters { get; set; }

    public DateTime? ExectionTime { get; set; }

    public string? ClientName { get; set; }

    public string? ClientIpAddress { get; set; }

    public string? BrowerInfo { get; set; }

    public string? Exception { get; set; }

    public string? Account { get; set; }

    public virtual Platform Platfrom { get; set; } = null!;
}
