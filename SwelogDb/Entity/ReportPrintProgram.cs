using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportPrintProgram
{
    public string Program { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public string? ProgramPath { get; set; }

    public virtual ICollection<ReportWorkstationProgramRelation> ReportWorkstationProgramRelations { get; } = new List<ReportWorkstationProgramRelation>();
}
