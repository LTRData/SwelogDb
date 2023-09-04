using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportWorkstationProgramRelation
{
    public string WorkstationId { get; set; } = null!;

    public string Program { get; set; } = null!;

    public string? SubDirectory { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ReportPrintProgram ProgramNavigation { get; set; } = null!;
}
