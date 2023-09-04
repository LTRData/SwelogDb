using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwTodoList
{
    public string ModuleId { get; set; } = null!;

    public string? SourceId { get; set; }

    public string? SubId { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? ActionDescription { get; set; }

    public string? Responsible { get; set; }

    public string? Status { get; set; }

    public DateTime? PlannedCompletionDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? CompletionDate { get; set; }

    public int? PriorityNo { get; set; }

    public string? AuditStamp { get; set; }

    public int? TodoPriorityNo { get; set; }

    public string? ReferenceId { get; set; }

    public decimal? EstimatedTime { get; set; }

    public string? SourceDescription { get; set; }

    public string? CreatedBy { get; set; }
}
