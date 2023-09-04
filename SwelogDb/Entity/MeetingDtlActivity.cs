using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MeetingDtlActivity
{
    public string CompanyNo { get; set; } = null!;

    public string MeetingNo { get; set; } = null!;

    public int RecNo { get; set; }

    public DateTime? ActivityDate { get; set; }

    public string? Text { get; set; }

    public string? UserId { get; set; }

    public string? Finished { get; set; }

    public DateTime? FinishedDate { get; set; }

    public string? AuditStamp { get; set; }

    public int? RecId { get; set; }

    public string? FromWhere { get; set; }

    public DateTime? PlannedFinishedDate { get; set; }

    public string? FileNam { get; set; }

    public string? FileNameAndPath { get; set; }

    public int? MeetingDtlRecNo { get; set; }

    public string? ConnectedToMeetingNo { get; set; }

    public string? ProjectNumber { get; set; }

    public string? ToolServiceUpdated { get; set; }

    public string? DepartmentServiceUpdated { get; set; }

    public string? ToolNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public int? TodoPriorityNo { get; set; }

    public virtual MeetingHdr MeetingHdr { get; set; } = null!;
}
