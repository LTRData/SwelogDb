using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrystalReportMaster
{
    public string ReportId { get; set; } = null!;

    public string? ReportName { get; set; }

    public double? FormatCode { get; set; }

    public string? Template { get; set; }

    public string? AuditStamp { get; set; }

    public string LanguageCode { get; set; } = null!;
}
