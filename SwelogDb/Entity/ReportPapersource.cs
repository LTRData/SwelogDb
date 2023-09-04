using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportPapersource
{
    public decimal Sourceid { get; set; }

    public string Description { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual ICollection<ReportWorkstationFormatcodeSpooler> ReportWorkstationFormatcodeSpoolers { get; } = new List<ReportWorkstationFormatcodeSpooler>();

    public virtual ICollection<ReportWorkstationReportidSpooler> ReportWorkstationReportidSpoolers { get; } = new List<ReportWorkstationReportidSpooler>();
}
