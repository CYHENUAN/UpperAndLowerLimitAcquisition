using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class PMCStationDataX
{
    public long Id { get; set; }

    public string PDAId { get; set; } = null!;

    public string PMCStationNumber { get; set; } = null!;

    public string TransactionId { get; set; } = null!;

    /// <summary>
    /// 1:PDA to PMC, 2:PMC to PDA
    /// </summary>
    public int Direction { get; set; }

    public string DataName { get; set; } = null!;

    public string DataValue { get; set; } = null!;

    public DateTime CreationDateTime { get; set; }

    /// <summary>
    /// 0: New, 2: Processed, -1: HasError
    /// </summary>
    public int State { get; set; }

    /// <summary>
    /// PLCOPCClientHandler处理时间
    /// </summary>
    public DateTime? ProcessedDateTime { get; set; }
}
