using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceIndirectTime
{
    public string ActivityNo { get; set; } = null!;

    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public decimal? ResourceTime { get; set; }

    public decimal? ResourceCost { get; set; }

    public string? ActivityDescription { get; set; }

    public string? DirectActivityNo { get; set; }

    public string? AuditStamp { get; set; }

    public int SequenceNo { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public DateTime ActivityStart { get; set; }

    public string? DirectActivityType { get; set; }

    public int? ReportedBy { get; set; }

    public string? ProductionGroupId { get; set; }

    public DateTime? MpcStartDate { get; set; }

    public DateTime? MpcEndDate { get; set; }

    public string? TimePeriod { get; set; }

    public decimal? ResourceTimeForBonus { get; set; }

    public int? TextId { get; set; }

    public string? InterruptCode { get; set; }
}
