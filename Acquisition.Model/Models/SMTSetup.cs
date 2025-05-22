using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTSetup
{
    public int Id { get; set; }

    public string? SetupName { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int? State { get; set; }

    public virtual User? Creator { get; set; }

    public virtual User? Editor { get; set; }

    public virtual ICollection<SMTOnlineSetup> SMTOnlineSetups { get; set; } = new List<SMTOnlineSetup>();

    public virtual ICollection<SMTProgram> SMTPrograms { get; set; } = new List<SMTProgram>();

    public virtual ICollection<SMTSetupListItem> SMTSetupListItems { get; set; } = new List<SMTSetupListItem>();
}
