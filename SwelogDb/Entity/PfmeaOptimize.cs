using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PfmeaOptimize
{
    public int IdPfmeaOptimize { get; set; }

    public int? PfmeaId { get; set; }

    public int? VersionNumber { get; set; }

    public int? ParentId { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? PreventionAction { get; set; }

    public string? DetectionAction { get; set; }

    public string? Responsible { get; set; }

    public DateTime? TargetCompletionDate { get; set; }

    public string? OptimizationStatus { get; set; }

    public string? ActionTaken { get; set; }

    public DateTime? CompletedDate { get; set; }

    public int? Severity { get; set; }

    public int? Occurance { get; set; }

    public int? Detection { get; set; }

    public string? SpProdChar { get; set; }

    public string? PerformedBy { get; set; }

    public string? AuditStamp { get; set; }

    public string? RecType { get; set; }

    public int? BranchId { get; set; }

    public string? PlannedAction { get; set; }
}
