using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class StationGroup
{
    public int Id { get; set; }

    public string GroupNumber { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public int? EditorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? FactoryId { get; set; }

    public int State { get; set; }

    public int? CreatorId { get; set; }

    public virtual ICollection<BOMItem> BOMItems { get; set; } = new List<BOMItem>();

    public virtual ICollection<Certification_User> Certification_Users { get; set; } = new List<Certification_User>();

    public virtual ICollection<EDocument_Relationship> EDocument_Relationships { get; set; } = new List<EDocument_Relationship>();

    public virtual User? Editor { get; set; }

    public virtual Factory? Factory { get; set; }

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();

    public virtual ICollection<ProcessStep> ProcessSteps { get; set; } = new List<ProcessStep>();

    public virtual ICollection<QualityHoldForm> QualityHoldForms { get; set; } = new List<QualityHoldForm>();

    public virtual ICollection<Station_StationGroup> Station_StationGroups { get; set; } = new List<Station_StationGroup>();

    public virtual ICollection<Stations_Skill> Stations_Skills { get; set; } = new List<Stations_Skill>();
}
