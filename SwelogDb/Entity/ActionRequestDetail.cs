using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActionRequestDetail
{
    public string OrderNumber { get; set; } = null!;

    public int ActionNumber { get; set; }

    public int LineNumber { get; set; }

    public string? Comment { get; set; }

    public string? Incharge { get; set; }

    public DateTime? PlannedDate { get; set; }

    public DateTime? CompletionDate { get; set; }

    public string? AuditStamp { get; set; }

    public int IdActionRequestDetail { get; set; }

    public string? MeetingNo { get; set; }

    public virtual ActionRequest OrderNumberNavigation { get; set; } = null!;
}
