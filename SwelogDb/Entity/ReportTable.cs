using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportTable
{
    public string ReportId { get; set; } = null!;

    public string? ReportName { get; set; }

    public byte[]? ReportSyntax { get; set; }

    public string? ReportPrompt { get; set; }

    public string? AuditStamp { get; set; }

    public string? Path { get; set; }

    public string? Favourite { get; set; }
}
