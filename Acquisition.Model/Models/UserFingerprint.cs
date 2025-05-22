using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class UserFingerprint
{
    public int ID { get; set; }

    public int UserID { get; set; }

    public string? DeviceCode { get; set; }

    public byte[] FingerprintTemplate1 { get; set; } = null!;

    public byte[]? FingerprintTemplate2 { get; set; }

    public byte[]? FingerprintTemplate3 { get; set; }

    public byte[]? FingerprintTemplate4 { get; set; }

    public byte[]? FingerprintTemplate5 { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? Enable { get; set; }

    public virtual User User { get; set; } = null!;
}
