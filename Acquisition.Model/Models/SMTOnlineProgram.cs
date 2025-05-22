using System;
using System.Collections.Generic;

namespace Acquisition.Model.Models;

public partial class SMTOnlineProgram
{
    public int Id { get; set; }

    public int SMTLineId { get; set; }

    public int Coveyor { get; set; }

    public int Side { get; set; }

    public int ProgramId { get; set; }

    public DateTime? TransferDateTime { get; set; }

    public int? CreatorId { get; set; }

    public virtual User? Creator { get; set; }

    public virtual SMTProgram Program { get; set; } = null!;

    public virtual SMTLine SMTLine { get; set; } = null!;
}
