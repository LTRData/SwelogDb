using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SystemParameter
{
    public string CompanyId { get; set; } = null!;

    public string? SOwnerId { get; set; }

    public string? SCountryCode { get; set; }

    public string? SLanguageCode { get; set; }

    public string? SCurrencyCode { get; set; }

    public string? SMarketCode { get; set; }

    public string? SBlockingStatus { get; set; }

    public string? SCustomerCategory { get; set; }

    public string? SCustFactoringOpt { get; set; }

    public string? SCustDiscountCode { get; set; }

    public string? SSuppDiscountCode { get; set; }

    public string? SCustExportStatus { get; set; }

    public decimal? SCreditLimit { get; set; }

    public decimal? SCustomerOrderLimit { get; set; }

    public string? SPayTermCode { get; set; }

    public string? SDeliveryTermsCode { get; set; }

    public string? STransportModeCode { get; set; }

    public string? SEuTranspModeCode { get; set; }

    public string? SReminderRequestOpt { get; set; }

    public string? SInvoiceChargeOption { get; set; }

    public string? SIntInvPayTermCode { get; set; }

    public short? SDeliveryTimeInDays { get; set; }

    public short? STransportTimeInDay { get; set; }

    public string? SVatCode { get; set; }

    public string? SSalesmanCode { get; set; }

    public string? STerritoryCode { get; set; }

    public string? SSupplierImportCode { get; set; }

    public string? SFreeDelMonthFlag { get; set; }

    public string? SManufacturerId { get; set; }

    public string? SOurReferenceCust { get; set; }

    public string? SOurReferenceSupp { get; set; }

    public string? SItemEanNrCode { get; set; }

    public string? SCustomerInvNrCode { get; set; }

    public string? SQuotationNrCode { get; set; }

    public string? SDeliveryNoteNrCode { get; set; }

    public string? SNumberRangeForMfgOrder { get; set; }

    public string? SNumberRangeForPallet { get; set; }

    public string? SNumberRangeForC { get; set; }

    public string? SNumberRangeForD { get; set; }

    public string? InInspectionStatus { get; set; }

    public string? EmptyPalletStatus { get; set; }

    public string? SItemEanNrSeriesId { get; set; }

    public string? SNumberSeriesForMfgOrder { get; set; }

    public string? SNumberSeriesForPallet { get; set; }

    public string? SNumberSeriesForC { get; set; }

    public string? SNumberSeriesForD { get; set; }

    public string? SDatemask { get; set; }

    public string? CustomerOrderCode { get; set; }

    public string? PurchaseOrderCode { get; set; }

    public string? OfferCode { get; set; }

    public string? CustomerContractOrderCode { get; set; }

    public string? CustomerDeliveryPlan { get; set; }

    public string? DeliveryOrderCode { get; set; }

    public string? InternalOrderCode { get; set; }

    public string? AdjustmentOrderCode { get; set; }

    public string? CashOrderCode { get; set; }

    public string? CreditNoteCode { get; set; }

    public string? SupplierContractOrderCode { get; set; }

    public string? SupplierDeliveryPlan { get; set; }

    public string? QuotationPrintFunctionCode { get; set; }

    public string? QtyAllocationFunctionCode { get; set; }

    public string? OrderAcknowledgeCode { get; set; }

    public string? PicklistPrintFunctionCode { get; set; }

    public string? DelNotePrintFunctionCode { get; set; }

    public string? DispatchFeedbackCode { get; set; }

    public string? InvoicingFunctionCode { get; set; }

    public string? MasterItemType { get; set; }

    public string? PopularItemType { get; set; }

    public string? CustomerItemType { get; set; }

    public string? KitItemType1 { get; set; }

    public string? KitItemType2 { get; set; }

    public string? KitItemType3 { get; set; }

    public string? ItemsWithQuantityType { get; set; }

    public string? ItemsWithoutQuantityType { get; set; }

    public string? OrderAcknowledgementDoc { get; set; }

    public string? CashMemoDoc { get; set; }

    public string? ProformaInvoiceDoc { get; set; }

    public string? QuotationDoc { get; set; }

    public string? AdvancedInvoiceDoc { get; set; }

    public string? PicklistDoc { get; set; }

    public string? PackingInstructionDoc { get; set; }

    public string? DeliveryNoteDoc { get; set; }

    public string? DispatchListDoc { get; set; }

    public string? DeliveryDocuments { get; set; }

    public string? InvoiceDocuments { get; set; }

    public string? BlockedOrderStatus { get; set; }

    public string? QuantityOrderedStatus { get; set; }

    public string? QuantityAllocatedStatus { get; set; }

    public string? CustomerDeliveryPlanStatus { get; set; }

    public string? QtyOnDelOrderStatus { get; set; }

    public string? QtyOnPickListStatus { get; set; }

    public string? QuantityDespatchedStatus { get; set; }

    public string? QuantityInvoicedStatus { get; set; }

    public string? QtyReturnedRejectedStatus { get; set; }

    public string? PurchaseOrderStatus { get; set; }

    public string? SupContractOrderStatus { get; set; }

    public string? SupplierDeliveryPlanStatus { get; set; }

    public string? ManufacturingDays { get; set; }

    public string? StraightPieceRateCode { get; set; }

    public string? MixedPieceRateCode { get; set; }

    public string? TimePieceRateCode { get; set; }

    public string? GroupPieceRateCode { get; set; }

    public string? EstimatePieceRateCode { get; set; }

    public string? NrpItemLevelCalcTag { get; set; }

    public string? ItemBlockedStatus { get; set; }

    public string? MpsItemType { get; set; }

    public string? MpsLotCode { get; set; }

    public DateTime? DefaultSystemDate { get; set; }

    public DateTime? PlanningPeriodStartDate { get; set; }

    public DateTime? NrpPlanningPeriodEndDate { get; set; }

    public decimal? NrpPercentStorageCost { get; set; }

    public decimal? NrpLotFixedOrderCost { get; set; }

    public decimal? NrpOpnFixedOrderCost { get; set; }

    public short? NrpAnnualNoOfWeeks { get; set; }

    public string? NrpProductionForecastFlag { get; set; }

    public DateTime? NrpStartPeriodProdnFore { get; set; }

    public DateTime? NrpEndPeriodProdnFore { get; set; }

    public string? NrpCustomerOrderFlag { get; set; }

    public DateTime? NrpStartPeriodCustOrder { get; set; }

    public DateTime? NrpEndPeriodCustOrder { get; set; }

    public string? NrpDeliveryPlanFlag { get; set; }

    public DateTime? NrpStartPeriodDelPlan { get; set; }

    public DateTime? NrpEndPeriodDelPlan { get; set; }

    public string? InternalOrderFlag { get; set; }

    public DateTime? StartPeriodInternalOrder { get; set; }

    public DateTime? EndPeriodInternalOrder { get; set; }

    public short? NrpDaysToMoveForward { get; set; }

    public short? NrpDaysToMoveBackward { get; set; }

    public DateTime? NrpMfgOrderFirmUpto { get; set; }

    public DateTime? MfgOrderPlannedUpto { get; set; }

    public DateTime? NrpPurOrderFirmUpto { get; set; }

    public DateTime? PurOrderPlannedUpto { get; set; }

    public string? NrpExistPurOrderAddFlag { get; set; }

    public string? NrpLotRoundingFlag { get; set; }

    public string? NrpLotCode { get; set; }

    public string? CurrentLanguageCode { get; set; }

    public string? AuditStamp { get; set; }

    public string? PhantomTypeCode { get; set; }

    public string? CurrencyExchangeName { get; set; }

    public string? InvoiceReferenceCode { get; set; }

    public string? GoodsReferenceCode { get; set; }

    public string? InvRoutingReferenceCode { get; set; }

    public string? MfgOrderReleasedStatus { get; set; }

    public string? CostCentreOption { get; set; }

    public string? CountryGroupCode { get; set; }

    public string? DefaultAccountCode { get; set; }

    public decimal? PostalTaxPercentage { get; set; }

    public decimal? InvoicingCharge { get; set; }

    public decimal? InvoiceChargeLimit { get; set; }

    public string? RoundOffCurrencyFlag { get; set; }

    public string? JobticketSizeDefault { get; set; }

    public int? AbcA { get; set; }

    public int? AbcB { get; set; }

    public int? NrpShiftEarlyAllowableDay { get; set; }

    public int? NrpShiftLaterMinimumDays { get; set; }

    public string? PurchasedItem { get; set; }

    public string? ManufacturedItem { get; set; }

    public string? RawMaterial { get; set; }

    public DateTime? FrozenPeriodFrom { get; set; }

    public DateTime? FrozenPeriodTo { get; set; }

    public decimal? RawMatOverheadPercent { get; set; }

    public decimal? PurchOverheadPercent { get; set; }

    public decimal? SocialCostPercentage { get; set; }

    public string? DefaultDeviationFlag { get; set; }

    public decimal? DefaultDeviationPercentage { get; set; }

    public string? WeightUnitMeasure { get; set; }

    public string? VolumeUnitMeasure { get; set; }

    public string? LengthMeasureCode { get; set; }

    public string? AreaMeasureCode { get; set; }

    public string? VolumeMeasureCode { get; set; }

    public string? PartialWithdrawFlagMfg { get; set; }

    public string? PartialWithdrawFlagCo { get; set; }

    public string? DefaultWarehouseId { get; set; }

    public DateTime? ForecastDate { get; set; }

    public string? BoughtPieceRateCode { get; set; }

    public string? ReportRejections { get; set; }

    public string? HiredResourceType { get; set; }

    public DateTime? NrpCalculationStarted { get; set; }

    public DateTime? NrpCalculationEnded { get; set; }

    public short? NrpVariableLotCodeWeeks { get; set; }

    public string? NrpCalculationStatus { get; set; }

    public string? NewItemPrefix { get; set; }

    public string? DefaultResourceNo { get; set; }

    public string? DefaultStockYard { get; set; }

    public byte? PrefixLength { get; set; }

    public string? WeightMeasureCode { get; set; }

    public string? CustDefaultDeliveryAddress { get; set; }

    public string? PalletFlag { get; set; }

    public string? AccumulatePriorLoadFlag { get; set; }

    public string? StandardPriceDifference { get; set; }

    public short? NrpPlanningPeriodEnd { get; set; }

    public string? NrpCreateSingleOrder { get; set; }

    public string? MosItemLevelCalcTag { get; set; }

    public short? MosPlanningPeriodEnd { get; set; }

    public decimal? MosPercentStorageCost { get; set; }

    public decimal? MosLotFixedOrderCost { get; set; }

    public decimal? MosOpnFixedOrderCost { get; set; }

    public string? MosProductionForecastFlag { get; set; }

    public DateTime? MosStartPeriodProdnFore { get; set; }

    public DateTime? MosEndPeriodProdnFore { get; set; }

    public string? MosProdnForecastId { get; set; }

    public string? MosCustomerOrderFlag { get; set; }

    public DateTime? MosStartPeriodCustOrder { get; set; }

    public DateTime? MosEndPeriodCustOrder { get; set; }

    public string? MosDeliveryPlanFlag { get; set; }

    public DateTime? MosStartPeriodDelPlan { get; set; }

    public DateTime? MosEndPeriodDelPlan { get; set; }

    public string? MosMfgProgramFlag { get; set; }

    public DateTime? MosStartPeriodMfgProgram { get; set; }

    public DateTime? MosEndPeriodMfgProgram { get; set; }

    public string? MosMfgProgramId { get; set; }

    public short? MosDaysToMoveForward { get; set; }

    public short? MosDaysToMoveBackward { get; set; }

    public short? MosMfgOrderFirmUpto { get; set; }

    public string? MosExistPurOrderAddFlag { get; set; }

    public string? MosLotRoundingFlag { get; set; }

    public string? MosLotCode { get; set; }

    public short? MosVariableLotCodeWeeks { get; set; }

    public short? MosFrozenPeriodTo { get; set; }

    public DateTime? MosCalculationStarted { get; set; }

    public DateTime? MosCalculationEnded { get; set; }

    public string? MosCalculationStatus { get; set; }

    public string? MosCreateSingleOrder { get; set; }

    public short? PosPlanningPeriodEnd { get; set; }

    public decimal? PosPercentStorageCost { get; set; }

    public decimal? PosLotFixedOrderCost { get; set; }

    public decimal? PosOpnFixedOrderCost { get; set; }

    public short? PosShiftEarlyAllowableDay { get; set; }

    public short? PosShiftLaterMinimumDays { get; set; }

    public short? PosPurOrderFirmUpto { get; set; }

    public string? PosCreateSingleOrder { get; set; }

    public string? PosLotRoundingFlag { get; set; }

    public string? PosLotCode { get; set; }

    public short? PosVariableLotCodeWeeks { get; set; }

    public short? PosFrozenPeriodTo { get; set; }

    public DateTime? PosCalculationStarted { get; set; }

    public DateTime? PosCalculationEnded { get; set; }

    public string? PosCalculationStatus { get; set; }

    public string? GeneralReferenceCode { get; set; }

    public int? NoOfDaysInWeek { get; set; }

    public string? MosDailyWeeklyDemand { get; set; }

    public string? PosDailyWeeklyDemand { get; set; }

    public string? MosCalculateForMinQty { get; set; }

    public string? MosStopBetweenLevels { get; set; }

    public short? MosNextLevelToStop { get; set; }

    public string? PosCalculateForMinQty { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Country? SCountryCodeNavigation { get; set; }

    public virtual CurrencyTable? SCurrencyCodeNavigation { get; set; }

    public virtual CustomerCategory? SCustomerCategoryNavigation { get; set; }

    public virtual DeliveryTerm? SDeliveryTermsCodeNavigation { get; set; }

    public virtual EuTransportCode? SEuTranspModeCodeNavigation { get; set; }

    public virtual InterestPaymentTerm? SIntInvPayTermCodeNavigation { get; set; }

    public virtual Market? SMarketCodeNavigation { get; set; }

    public virtual InvoicePaymentTerm? SPayTermCodeNavigation { get; set; }

    public virtual Salesman? SSalesmanCodeNavigation { get; set; }

    public virtual Territory? STerritoryCodeNavigation { get; set; }

    public virtual Tax? SVatCodeNavigation { get; set; }
}
