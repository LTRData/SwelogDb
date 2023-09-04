using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpGnlDtlDtl
{
    public int RecId { get; set; }

    public string? ReportId { get; set; }

    public string? ActionWhat { get; set; }

    public string? ActionWho { get; set; }

    public DateTime? ActionWhen { get; set; }

    public string? ActionSign { get; set; }

    public DateTime? ActionCompletedDate { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? PlannedFinishedDate { get; set; }

    public string? MeetingNo { get; set; }

    public string? Finished { get; set; }

    public string? DepartmentNo { get; set; }

    public string? ResourceNo { get; set; }

    public string? WhichType { get; set; }

    public string? MfgOrderType { get; set; }

    public string? ProductGroup { get; set; }

    public DateTime? StartDate { get; set; }
}
