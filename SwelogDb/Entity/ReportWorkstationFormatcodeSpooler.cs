using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportWorkstationFormatcodeSpooler
{
    public string WorkstationId { get; set; } = null!;

    public short FormatCode { get; set; }

    public string Spooler { get; set; } = null!;

    public decimal? Papersource { get; set; }

    public string? AuditStamp { get; set; }

    public string? DefaultPrinter { get; set; }

    public virtual ReportFormatcode FormatCodeNavigation { get; set; } = null!;

    public virtual ReportPapersource? PapersourceNavigation { get; set; }

    public virtual ReportWorkstation Workstation { get; set; } = null!;
}
