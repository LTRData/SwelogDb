using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportWorkstation
{
    public string WorkstationId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string SystemWorkstation { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public string? UserId { get; set; }

    public string? PdfPrintingLicense { get; set; }

    public virtual ICollection<ReportWorkstationFormatcodeSpooler> ReportWorkstationFormatcodeSpoolers { get; } = new List<ReportWorkstationFormatcodeSpooler>();
}
