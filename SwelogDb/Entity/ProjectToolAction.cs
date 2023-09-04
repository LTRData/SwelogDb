using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProjectToolAction
{
    public int RecId { get; set; }

    public string? ProjectNumber { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? ActionDescription { get; set; }

    public string? PerformedBy { get; set; }

    public string? Status { get; set; }

    public DateTime? CompletionDate { get; set; }

    public DateTime? PlannedCompletionDate { get; set; }

    public string? ToolNumber { get; set; }

    public string? AuditStamp { get; set; }

    public string? ProjectType { get; set; }

    public DateTime? StartDate { get; set; }

    public int? TodoPriorityNo { get; set; }

    public virtual ProjectHeader? ProjectNumberNavigation { get; set; }
}
