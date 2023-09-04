using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MeetingDtl
{
    public string CompanyNo { get; set; } = null!;

    public string MeetingNo { get; set; } = null!;

    public int RecNo { get; set; }

    public string? Text { get; set; }

    public string? ReportId { get; set; }

    public string? AuditStamp { get; set; }

    public string? PathNameWithFileNam { get; set; }

    public string? FileNam { get; set; }

    public string? PathNameWithFileNam2 { get; set; }

    public string? FileNam2 { get; set; }

    public string? ConnectedToMeetingNo { get; set; }

    public string? ProjectNo { get; set; }

    public virtual MeetingHdr MeetingHdr { get; set; } = null!;
}
