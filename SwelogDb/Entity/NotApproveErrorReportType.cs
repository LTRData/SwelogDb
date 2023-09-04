using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NotApproveErrorReportType
{
    public string ReportType { get; set; } = null!;

    public string? ReportDescription { get; set; }

    public int? Color { get; set; }
}
