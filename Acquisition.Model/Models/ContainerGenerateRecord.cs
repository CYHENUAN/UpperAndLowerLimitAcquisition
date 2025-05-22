using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class ContainerGenerateRecord
{
    public long Id { get; set; }

    public long ContainerId { get; set; }

    public int GenerateType { get; set; }

    public int FormId { get; set; }

    public int FormItemNumber { get; set; }

    public int CreationLocationId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public int CreatorId { get; set; }

    public virtual Container Container { get; set; } = null!;

    public virtual Location CreationLocation { get; set; } = null!;

    public virtual User Creator { get; set; } = null!;

    public virtual FormType GenerateTypeNavigation { get; set; } = null!;
}
