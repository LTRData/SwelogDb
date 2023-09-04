using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportSystempapercode
{
    public decimal SystemPapersizeCode { get; set; }

    public string Description { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual ICollection<ReportFormatcode> ReportFormatcodes { get; } = new List<ReportFormatcode>();
}
