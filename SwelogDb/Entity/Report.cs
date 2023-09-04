using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Report
{
    public string CompanyNo { get; set; } = null!;

    public string ReportNo { get; set; } = null!;

    public string? Description { get; set; }

    public string? Header { get; set; }

    public string? Trailer { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
