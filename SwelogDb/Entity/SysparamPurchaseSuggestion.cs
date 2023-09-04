using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SysparamPurchaseSuggestion
{
    public string CompanyId { get; set; } = null!;

    public string? CreateSingleOrder { get; set; }

    public string? LotRoundingFlag { get; set; }

    public string? DailyWeeklyDemand { get; set; }

    public string? CalculateForMinQty { get; set; }

    public double? PlanningPeriodEnd { get; set; }

    public decimal? PercentStorageCost { get; set; }

    public decimal? LotFixedOrderCost { get; set; }

    public decimal? OpnFixedOrderCost { get; set; }

    public double? PurOrderFirmUpto { get; set; }

    public double? ShiftEarlyAllowableDay { get; set; }

    public double? ShiftLaterMinimumDays { get; set; }

    public string? LotCode { get; set; }

    public double? VariableLotCodeWeeks { get; set; }

    public double? FrozenPeriodTo { get; set; }

    public DateTime? CalculationStarted { get; set; }

    public DateTime? CalculationEnded { get; set; }

    public string? CalculationStatus { get; set; }

    public string? AuditStamp { get; set; }

    public string? PosDoNotCalculateMinQty { get; set; }

    public short? GeneralMarginTime { get; set; }

    public string? ShowOnlyCostAccInOrderLine { get; set; }

    public string? DoNotShowExstgOrderInResultRep { get; set; }

    public string? ShowAdminWindowAtStartup { get; set; }

    public string? ShowPurchaseWindowAtStartup { get; set; }

    public string? SendNotfnToAdminAtDefCoding { get; set; }

    public string? AdminUserid { get; set; }

    public int? RetainBackupDays { get; set; }

    public string? AddMinQtyToFirstDemand { get; set; }

    public string? VmiShowAdminWindowAtStartup { get; set; }

    public string? VmiShowPurchaseWindowAtStartup { get; set; }

    public string? VmiAdminUserid { get; set; }

    public short? WaitingDaysToProcessPrel { get; set; }

    public string? IncludeFullyDelLinesInPoPrint { get; set; }

    public string? UseLimits { get; set; }

    public string? LastExecutionUserid { get; set; }

    public string? LastExecutionPlannerid { get; set; }

    public string? LastExecutionCostcentre { get; set; }

    public string? DeactivateDemandsFromMoSugg { get; set; }

    public string? ShowFreeTextInPurcOrder { get; set; }

    public string? AddToLatestPo { get; set; }

    public string? UseridAsOurRefInPurchaseOrder { get; set; }

    public string? ShowItemdescSearch { get; set; }

    public string? ResultReportInYyyywwd { get; set; }

    public string? ReduceForecastWithDemands { get; set; }

    public string? ProductionForecastFlag { get; set; }

    public DateTime? StartPeriodProdnForecast { get; set; }

    public DateTime? EndPeriodProdnForecast { get; set; }

    public double? SuggestionsToPlan { get; set; }

    public double? SuggestionsToPurchComp { get; set; }

    public string? ShowRecvdQtyAndBalQtyInPo { get; set; }

    public string? ShortcutToInspectionYn { get; set; }

    public string? CertificateRequiredYn { get; set; }

    public string? ShowStockQtyUomInPo { get; set; }

    public string? DialogDefaultDeldateYn { get; set; }

    public string? DialogDefaultMarkAllLinesYn { get; set; }

    public short? GoodsentryPalletLabel { get; set; }

    public string? RequirePriceYn { get; set; }

    public string? ValidCategories { get; set; }

    public short? OrderFromLotCatalogDays { get; set; }

    public short? DaysAheadToTransfer { get; set; }

    public string? CalculateForMinQtyFromSchedule { get; set; }

    public string? OnlyOnePurchorderPerPurchoprYn { get; set; }

    public string? NormalItemsAsTempItems { get; set; }

    public string? GoodsArrivedFlag { get; set; }

    public string? ItemSupplListDiscountDefaultYn { get; set; }

    public string? ChgPlDelDateWhenAvailDateIsChgd { get; set; }

    public string? DocumentationIds { get; set; }

    public string? DocumentUniqueOrdertext { get; set; }

    public string? ShowWarningIfQtyPerPalletMissing { get; set; }

    public string? UpdateItemSuppItemPriceInOc { get; set; }

    public int? DaysHistorikLocations { get; set; }

    public string? OfferNotificationRecepients { get; set; }

    public string? ShowExtraDesc { get; set; }

    public bool? CreateFreightNoteForPurchOpr { get; set; }
}
