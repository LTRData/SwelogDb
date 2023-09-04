using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SysparamMfgSuggestion
{
    public string CompanyId { get; set; } = null!;

    public string? ProductionForecastFlag { get; set; }

    public DateTime? StartPeriodProdnForecast { get; set; }

    public DateTime? EndPeriodProdnForecast { get; set; }

    public string? ProdnForecastId { get; set; }

    public string? CustomerOrderFlag { get; set; }

    public DateTime? StartPeriodCustOrder { get; set; }

    public DateTime? EndPeriodCustOrder { get; set; }

    public string? DeliveryPlanFlag { get; set; }

    public DateTime? StartPeriodDelPlan { get; set; }

    public DateTime? EndPeriodDelPlan { get; set; }

    public string? MfgProgramFlag { get; set; }

    public DateTime? StartPeriodMfgProgram { get; set; }

    public DateTime? EndPeriodMfgProgram { get; set; }

    public string? MfgProgramId { get; set; }

    public string? ExistPurOrderAddFlag { get; set; }

    public string? LotRoundingFlag { get; set; }

    public string? StopBetweenLevels { get; set; }

    public string? CreateSingleOrder { get; set; }

    public string? DailyWeeklyDemand { get; set; }

    public string? CalculateForMinQty { get; set; }

    public string? ItemLevelCalcTag { get; set; }

    public double? PlanningPeriodEnd { get; set; }

    public decimal? PercentStorageCost { get; set; }

    public decimal? LotFixedOrderCost { get; set; }

    public decimal? OpnFixedOrderCost { get; set; }

    public double? DaysToMoveForward { get; set; }

    public double? DaysToMoveBackward { get; set; }

    public double? MfgOrderFirmUpto { get; set; }

    public string? LotCode { get; set; }

    public double? VariableLotCodeWeeks { get; set; }

    public double? FrozenPeriodTo { get; set; }

    public DateTime? CalculationStarted { get; set; }

    public DateTime? CalculationEnded { get; set; }

    public string? CalculationStatus { get; set; }

    public string? AuditStamp { get; set; }

    public string? DeleteNotPrintedMfgOrders { get; set; }

    public short? NextLevelToStop { get; set; }

    public string? MosDoNotCalculateMinQty { get; set; }

    public short? GeneralBufferTime { get; set; }

    public string? AddMinQtyToFirstDemand { get; set; }

    public string? ReduceForecastWithDemands { get; set; }

    public double? SuggestionsToPlan { get; set; }

    public double? SuggestionsToPurchComp { get; set; }

    public string? LastExecutionUserid { get; set; }

    public string? CavityMoCreationSource { get; set; }

    public string? SelectSingleToolCavityItems { get; set; }

    public short? DaysAheadToTransfer { get; set; }

    public string? FixBadReservations { get; set; }

    public string? DateformatCcyywwdYn { get; set; }

    public string? AutoMfgOrder { get; set; }

    public string? ChangeResDateWithMoMove { get; set; }

    public string? ContainerPlanningFlag { get; set; }

    public string? UpdateItemBalanceYn { get; set; }

    public string? FixBadReservationsSchedule { get; set; }

    public string? ProcessItemsInPreparation { get; set; }
}
