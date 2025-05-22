using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class OrderConfirmation
{
    public long Id { get; set; }

    public long Tran_Id { get; set; }

    public string WorkOrderNumber { get; set; } = null!;

    public string? MaterialNumber { get; set; }

    public string? ProcessStep_ERP { get; set; }

    public int ProcessStepSequence_MES { get; set; }

    /// <summary>
    /// 1:Backflush
    /// </summary>
    public int Transcation_Type { get; set; }

    public decimal PassQuantity { get; set; }

    public decimal ScrapQuantity { get; set; }

    public string StationNumber { get; set; } = null!;

    public DateTime DateTimeFrom { get; set; }

    public DateTime DateTimeTo { get; set; }

    public decimal TotalPassQuantity { get; set; }

    public decimal TotalScrapQuantity { get; set; }

    public string CompanyCode { get; set; } = null!;

    public string FactoryCode { get; set; } = null!;

    /// <summary>
    /// 1:MES-&gt;ERP, 2:ERP-&gt;MES
    /// </summary>
    public int Source { get; set; }

    /// <summary>
    /// 0:等待MES处理，1：MES正在处理，2：MES处理完毕OK，-1：MES处理出错
    /// </summary>
    public int Status_MES { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Stamp { get; set; }

    public string UserCode { get; set; } = null!;

    public string? ErrorCode_MES { get; set; }

    public string? ErrorMessage_MES { get; set; }

    /// <summary>
    /// 0:等待ERP处理，1：ERP正在处理，2：ERP处理完毕OK，-1：ERP处理出错
    /// </summary>
    public int? Status_ERP { get; set; }

    public string? ErrorCode_ERP { get; set; }

    public string? ErrorMessage_ERP { get; set; }
}
