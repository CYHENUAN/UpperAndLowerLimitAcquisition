using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class EDocumentType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int State { get; set; }

    public virtual ICollection<EDocument> EDocuments { get; set; } = new List<EDocument>();
}
