using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class TPMWorkRecord
{
    public int Id { get; set; }

    public int TPMWorkOrderItemId { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? FinishDateTime { get; set; }

    public string? BeforePicture1 { get; set; }

    public string? BeforePicture2 { get; set; }

    public string? BeforePicture3 { get; set; }

    public double? BeforeValue { get; set; }

    public string? BeforeProfileData { get; set; }

    public int? BeforeResult { get; set; }

    public string? AfterPicture1 { get; set; }

    public string? AfterPicture2 { get; set; }

    public string? AfterPicture3 { get; set; }

    public double? AfterValue { get; set; }

    public string? AfterProfileData { get; set; }

    public int? FinalResult { get; set; }

    public virtual ICollection<TPMMaterialRecord> TPMMaterialRecords { get; set; } = new List<TPMMaterialRecord>();

    public virtual TPMWorkOrderItem TPMWorkOrderItem { get; set; } = null!;
}
