using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EDocument
{
    public int Id { get; set; }

    public string DocumentCode { get; set; } = null!;

    public int Revision { get; set; }

    public string Name { get; set; } = null!;

    public string? VersionNumber { get; set; }

    public int DocumentTypeId { get; set; }

    public string DocumentURI { get; set; } = null!;

    public int? InitiatorId { get; set; }

    public int? EditorId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public DateTime? ValidBegin { get; set; }

    public DateTime? ValidEnd { get; set; }

    public int State { get; set; }

    public virtual EDocumentType DocumentType { get; set; } = null!;

    public virtual ICollection<EDocument_Relationship> EDocument_Relationships { get; set; } = new List<EDocument_Relationship>();

    public virtual User? Editor { get; set; }

    public virtual User? Initiator { get; set; }

    public virtual ICollection<TPMWorkOrderItem> TPMWorkOrderItems { get; set; } = new List<TPMWorkOrderItem>();

    public virtual ICollection<TPMWorkPlanItem> TPMWorkPlanItems { get; set; } = new List<TPMWorkPlanItem>();
}
