using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportWorkstationReportidSpooler
{
    public string WorkstationId { get; set; } = null!;

    public string ReportId { get; set; } = null!;

    public string Spooler { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public decimal? Copies { get; set; }

    public decimal? Papersource { get; set; }

    public string? DefaultPrinter { get; set; }

    public string? PrePrinted { get; set; }

    public string? LogoPrePrinted { get; set; }

    public virtual ReportPapersource? PapersourceNavigation { get; set; }
}
