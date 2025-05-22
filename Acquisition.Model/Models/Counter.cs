using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class Counter
{
    public string Key { get; set; } = null!;

    public int Value { get; set; }

    public DateTime? ExpireAt { get; set; }
}
