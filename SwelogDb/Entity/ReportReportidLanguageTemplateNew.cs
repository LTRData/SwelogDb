using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportReportidLanguageTemplateNew
{
    public string ReportId { get; set; } = null!;

    public string Language { get; set; } = null!;

    public string? ReportTemplate { get; set; }

    public string? AuditStamp { get; set; }

    public string? ExcelTemplate { get; set; }
}
