using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TriggerTable
{
    public string ItemNumber { get; set; } = null!;

    public short? ItemLevelCode { get; set; }

    public string? MpsMrpOrpIndicator { get; set; }

    public decimal? ReorderPoint { get; set; }

    public decimal? MinimumQuantity { get; set; }

    public string? LotCode { get; set; }

    public decimal? OrderLotQuantity { get; set; }

    public decimal? ItemAnnualRequirement { get; set; }

    public decimal? RequirementInWeek { get; set; }

    public short? InternalLeadTime { get; set; }

    public string? ItemStatus1 { get; set; }

    public decimal? CurrentBalance { get; set; }

    public decimal? ItemReservedQuantity { get; set; }

    public decimal? BalanceUnderInspection { get; set; }

    public decimal? CostPrice { get; set; }

    public short? TurnAroundTime { get; set; }

    public string? AuditStamp { get; set; }
}
