using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PfmeaAction
{
    public int IdPfmeaAction { get; set; }

    public int PfmeaId { get; set; }

    public int VersionNumber { get; set; }

    public int BranchId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? ActionDescription { get; set; }

    public string? ActionType { get; set; }

    public string? PerformedBy { get; set; }

    public DateTime? PlannedCompletionDate { get; set; }

    public string? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? CompletionDate { get; set; }

    public int? PriorityNo { get; set; }

    public int? TodoPriorityNo { get; set; }

    public decimal? ReportedTime { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Pfmea Pfmea { get; set; } = null!;
}
