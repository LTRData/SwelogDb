using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PoSuggestParameter
{
    public string CompanyId { get; set; } = null!;

    public short? PlanningPeriodEnd { get; set; }

    public decimal? PercentStorageCost { get; set; }

    public decimal? LotFixedOrderCost { get; set; }

    public decimal? OpnFixedOrderCost { get; set; }

    public short? ShiftEarlyAllowableDays { get; set; }

    public short? ShiftLaterMinimumDays { get; set; }

    public short? PurOrderFirmUpto { get; set; }

    public string? CreateSingleOrder { get; set; }

    public string? LotRoundingFlag { get; set; }

    public string? LotCode { get; set; }

    public short? VariableLotCodeWeeks { get; set; }

    public short? FrozenPeriodTo { get; set; }

    public DateTime? CalculationStarted { get; set; }

    public DateTime? CalculationEnded { get; set; }

    public string? CalculationStatus { get; set; }
}
