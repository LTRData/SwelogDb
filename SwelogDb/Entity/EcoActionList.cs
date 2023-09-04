using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoActionList
{
    public string ChangeOrderId { get; set; } = null!;

    public int ChangeOrderSerial { get; set; }

    public string ActionListId { get; set; } = null!;

    public int ActionSerial { get; set; }

    public string? ActionDescription { get; set; }

    public string? ResponsibleId { get; set; }

    public DateTime? ScheduledStartDate { get; set; }

    public DateTime? ActualStartDate { get; set; }

    public DateTime? ScheduledCompletionDate { get; set; }

    public DateTime? ActualCompletionDate { get; set; }

    public string? Comments { get; set; }

    public string? DistributionListId { get; set; }

    public string? Status { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ChangeOrderDtl ChangeOrder { get; set; } = null!;

    public virtual DistributionListHdr? DistributionList { get; set; }

    public virtual ICollection<EcoDocument> EcoDocuments { get; } = new List<EcoDocument>();

    public virtual ActionStatus? StatusNavigation { get; set; }
}
