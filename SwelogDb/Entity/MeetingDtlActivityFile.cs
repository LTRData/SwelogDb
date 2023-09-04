using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MeetingDtlActivityFile
{
    public int RecId { get; set; }

    public string CompanyNo { get; set; } = null!;

    public string MeetingNo { get; set; } = null!;

    public int RecNo { get; set; }

    public string? PathNameWithFileNam { get; set; }

    public string? FileNam { get; set; }

    public string? AuditStamp { get; set; }
}
