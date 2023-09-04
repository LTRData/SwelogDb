using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosParameter
{
    public string CompanyId { get; set; } = null!;

    public string? ItemLevelCalculationTag { get; set; }

    public short? PlanningPeriodEnd { get; set; }

    public decimal? PercentStorageCost { get; set; }

    public decimal? LotFixedOrderCost { get; set; }

    public decimal? OpnFixedOrderCost { get; set; }

    public string? ProductionForecastFlag { get; set; }

    public DateTime? StartPeriodProdnForecast { get; set; }

    public DateTime? EndPeriodProdnForecast { get; set; }

    public string? ProdnForecastId { get; set; }

    public string? CustomerOrderFlag { get; set; }

    public DateTime? StartPeriodCustOrder { get; set; }

    public DateTime? EndPeriodCustOrder { get; set; }

    public string? DeliveryPlanFlag { get; set; }

    public DateTime? StartPeriodDeliveryPlan { get; set; }

    public DateTime? EndPeriodDeliveryPlan { get; set; }

    public string? MfgProgramFlag { get; set; }

    public DateTime? StartPeriodMfgProgram { get; set; }

    public DateTime? EndPeriodMfgProgram { get; set; }

    public string? MfgProgramId { get; set; }

    public short? DaysToMoveForward { get; set; }

    public short? DaysToMoveBackward { get; set; }

    public short? MfgOrderFirmUpto { get; set; }

    public string? ExistingPurOrderAddFlag { get; set; }

    public string? LotRoundingFlag { get; set; }

    public string? LotCode { get; set; }

    public short? VariableLotCodeWeeks { get; set; }

    public short? FrozenPeriodTo { get; set; }

    public DateTime? CalculationStarted { get; set; }

    public DateTime? CalculationEnded { get; set; }

    public string? CalculationStatus { get; set; }

    public string? CreateSingleOrder { get; set; }
}
