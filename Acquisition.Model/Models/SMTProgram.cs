using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTProgram
{
    public int Id { get; set; }

    public string ProgramCode { get; set; } = null!;

    public int SMTLineId { get; set; }

    public int? MaterialId { get; set; }

    public int? Conveyor { get; set; }

    public int Side { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatorId { get; set; }

    public DateTime? EditDateTime { get; set; }

    public int? EditorId { get; set; }

    public int? State { get; set; }

    public int SetupId { get; set; }

    public virtual Material? Material { get; set; }

    public virtual SMTLine SMTLine { get; set; } = null!;

    public virtual ICollection<SMTOnlineProgram> SMTOnlinePrograms { get; set; } = new List<SMTOnlineProgram>();

    public virtual ICollection<SMTProgramDetail> SMTProgramDetails { get; set; } = new List<SMTProgramDetail>();

    public virtual SMTSetup Setup { get; set; } = null!;
}
