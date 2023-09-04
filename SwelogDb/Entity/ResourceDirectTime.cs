using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceDirectTime
{
    public string ItemNo { get; set; } = null!;

    public int LotNo { get; set; }

    public int OperationNo { get; set; }

    public DateTime ReportDateTime { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public decimal? ResourceTime { get; set; }

    public decimal? PlannedResourceTime { get; set; }

    public decimal? SetupTime { get; set; }

    public decimal? PlannedSetupTime { get; set; }

    public int? NoOfSetup { get; set; }

    public decimal? ProduceQty { get; set; }

    public decimal? ResourceCost { get; set; }

    public DateTime? MpcStartDate { get; set; }

    public DateTime? MpcEndDate { get; set; }

    public decimal? NotApproveQty { get; set; }

    public string? FinishFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? StartLimit { get; set; }

    public string? EndLimit { get; set; }

    public DateTime? StartDateTime { get; set; }

    public int? ReportedBy { get; set; }

    public int SequenceNo { get; set; }

    public string? ProductionGroupId { get; set; }

    public string? ActualResourceNumber { get; set; }

    public int? TextId { get; set; }
}
