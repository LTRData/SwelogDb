using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OfferAction
{
    public int IdOfferAction { get; set; }

    public string? OfferNumber { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? ActionDescription { get; set; }

    public string? PerformedBy { get; set; }

    public DateTime? PlannedCompletionDate { get; set; }

    public string? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? CompletionDate { get; set; }

    public string? AuditStamp { get; set; }

    public int? PriorityNo { get; set; }

    public decimal? ReportedTime { get; set; }

    public int? TodoPriorityNo { get; set; }

    public virtual OfferHeader? OfferNumberNavigation { get; set; }
}
