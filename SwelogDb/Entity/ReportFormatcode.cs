using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportFormatcode
{
    public short FormatCode { get; set; }

    public string Description { get; set; } = null!;

    public decimal SystemPapersizeCode { get; set; }

    public decimal SystemPrintOrientation { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ReportMaster> ReportMasters { get; } = new List<ReportMaster>();

    public virtual ICollection<ReportWorkstationFormatcodeSpooler> ReportWorkstationFormatcodeSpoolers { get; } = new List<ReportWorkstationFormatcodeSpooler>();

    public virtual ReportSystempapercode SystemPapersizeCodeNavigation { get; set; } = null!;
}
