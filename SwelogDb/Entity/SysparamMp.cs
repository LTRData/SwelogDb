using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SysparamMp
{
    public string CompanyId { get; set; } = null!;

    public string? ItemEanNrCode { get; set; }

    public string? ItemEanNrSeriesId { get; set; }

    public string? MfgOrderReleasedStatus { get; set; }

    public string? LengthMeasureCode { get; set; }

    public string? AreaMeasureCode { get; set; }

    public string? VolumeMeasureCode { get; set; }

    public string? EmptyPalletStatus { get; set; }

    public string? NumberRangeForPallet { get; set; }

    public string? NumberSeriesForPallet { get; set; }

    public string? NumberRangeForMfgOrder { get; set; }

    public string? NumberSeriesForMfgOrder { get; set; }

    public string? DefaultWarehouseId { get; set; }

    public string? StandardPriceDifference { get; set; }

    public string? AccumulatePriorLoadFlag { get; set; }

    public string? PartialWithdrawFlagMfg { get; set; }

    public string? DefaultStockYard { get; set; }

    public double? AbcA { get; set; }

    public double? AbcB { get; set; }

    public string? PalletFlag { get; set; }

    public string? ReportRejections { get; set; }

    public string? DefaultResourceNo { get; set; }

    public string? ManufacturingDays { get; set; }

    public decimal? RawMatOverheadPercent { get; set; }

    public decimal? PurchOverheadPercent { get; set; }

    public decimal? SocialCostPercentage { get; set; }

    public string? ReceiveOperationOption { get; set; }

    public string? WithdrawOperationOption { get; set; }

    public string? AuditStamp { get; set; }

    public short? TimeLimitCostCentre { get; set; }

    public short? ShowRequirementsUpto { get; set; }

    public decimal? CutlistPercentageWaste { get; set; }

    public string? CutlistInRequisition { get; set; }

    public string? CalcUsingCostPrice { get; set; }

    public string? CreateAv { get; set; }

    public string? UpdateLedger { get; set; }

    public string? JournalSeries { get; set; }

    public string? IncludeSuggestionsInCapacity { get; set; }

    public string? VariantItemGeneration { get; set; }

    public string? BatchSeries { get; set; }

    public decimal? QuantityDifferenceLimit { get; set; }

    public decimal? ValueDifferenceLimit { get; set; }

    public string? DefaultNotApproveCode { get; set; }

    public string? EstimateSetupSeparated { get; set; }

    public decimal? AdministrationPercentage { get; set; }

    public decimal? ProfitPercentage { get; set; }

    public decimal? ToleranceForReportedQuantity { get; set; }

    public string? ReceiveOperationOptionPurchopr { get; set; }

    public string? PropagateStructChgToMfgorder { get; set; }

    public string? ChangeRecvStoreLoc { get; set; }

    public string? CalcUsingItemsuppPrice { get; set; }

    public string? WithdrawFromHomeLocation { get; set; }

    public string? StocktakePrintPagebreak { get; set; }

    public string? ShowAtpDatesAsCcyywwd { get; set; }

    public string? TemplateItemForProject { get; set; }

    public string? OperationListForReworkOrder { get; set; }

    public string? CreateMoEstimateAlways { get; set; }

    public string? CopyMoToBasicdata { get; set; }

    public string? TemplateItemForComponent { get; set; }

    public string? TemplateItemForToolProject { get; set; }

    public string? TemplateItemForToolItem { get; set; }

    public string? ToolServiceCostCentre { get; set; }

    public string? ResourceCapacityOption { get; set; }

    public string? UseFixedOrderCostForPurchitems { get; set; }

    public string? StocktakeDoNotShowBalance { get; set; }

    public string? DepartmentServiceCostCentre { get; set; }

    public string? TriggerItemCreationFromTool { get; set; }

    public string? SimulationOrderNumber { get; set; }

    public decimal? MinimumMarginPercentage { get; set; }

    public string? FifoYn { get; set; }

    public string? NotAllowNegBalanceYn { get; set; }

    public string? CountryVinCode { get; set; }

    public string? ManufacturerVinCode { get; set; }

    public string? MfgCityVinCode { get; set; }

    public string? RequirePriceAtReceivalYn { get; set; }

    public string? EstimateCategorySelection { get; set; }

    public string? ReduceCostprcToSellprcMarg { get; set; }

    public string? TemplateItemForFixtureProject { get; set; }

    public string? TemplateItemForFixtureItem { get; set; }

    public int? PalletPrintCount { get; set; }

    public string? DefaultStoreLocationWip { get; set; }

    public string? DoNotDeductMinQtyFromAtpStock { get; set; }

    public string? ShowTotalReceiptReservedInAtp { get; set; }

    public string? WithdrawReportYn { get; set; }

    public string? PropagateOprChgToMfgorder { get; set; }

    public string? SuggestOverwithdrawalYn { get; set; }

    public string? WipCategorySelection { get; set; }

    public string? OperationListForAutoReworkOrder { get; set; }

    public decimal? SpeccostReworkPercentage { get; set; }

    public decimal? SpeccostRejectionPercentage { get; set; }

    public decimal? SpeccostToolservicePercentage { get; set; }

    public string? AutoUpdateItemAccumulator { get; set; }

    public string? PrintPalletLabelAtStockMovement { get; set; }

    public decimal? PurchoprOverheadPercent { get; set; }

    public string? AutoUpdateItemPeriodAccumulator { get; set; }

    public int? StockhistoryNoofLines { get; set; }

    public string? VariantIncludeItemSuppliersYn { get; set; }

    public string? VariantIncludeControlInstructionsYn { get; set; }

    public string? VariantIncludeCutlistYn { get; set; }

    public string? VariantIncludeOperationToolsYn { get; set; }

    public string? VariantIncludeCostpriceYn { get; set; }

    public string? VariantIncludeSellingpriceYn { get; set; }

    public string? VariantIncludeCustomerItemYn { get; set; }

    public string? TerminalWebpageAddress { get; set; }

    public string? WithdrawMaterialAtReceival { get; set; }

    public string? VariantIncludeTextInformationYn { get; set; }

    public string? JticketSimultanPrintoutWarningYn { get; set; }

    public int? Target8dExternPpm { get; set; }

    public string? AllowFinishingOperationBeforePrior { get; set; }

    public string? ItemDeletionCheckStructureYn { get; set; }

    public string? ItemDeletionCheckCustOrderYn { get; set; }

    public decimal? ImportPercentage { get; set; }

    public decimal? ConsPercentage { get; set; }

    public decimal? VatPercentage { get; set; }

    public string? DefaultSupplierItemNumberBlank { get; set; }

    public string? TemplateItemForOffer { get; set; }

    public int? DelayCloseAcrobatSeconds { get; set; }

    public string? WorkshopReportInHoursMinutes { get; set; }

    public string? AdjMoQtyAtFirstOpRep { get; set; }

    public string? TemplateItemForStructure { get; set; }

    public string? OperationListForFlowchart { get; set; }

    public short? WorkingWeekCount { get; set; }

    public bool? CreateMoTextFromCo { get; set; }

    public bool? CalcStockHistBalBeforeStocktake { get; set; }
}
