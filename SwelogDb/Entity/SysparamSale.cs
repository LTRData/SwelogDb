using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SysparamSale
{
    public string CompanyId { get; set; } = null!;

    public string? CustomerOrderCode { get; set; }

    public string? CustomerContractOrderCode { get; set; }

    public string? CashOrderCode { get; set; }

    public string? CreditNoteCode { get; set; }

    public string? WeightUnitMeasure { get; set; }

    public string? VolumeUnitMeasure { get; set; }

    public string? CustDefaultDeliveryAddress { get; set; }

    public string? MarketCode { get; set; }

    public string? VatCode { get; set; }

    public string? SalesmanCode { get; set; }

    public string? NewItemPrefix { get; set; }

    public string? AuditStamp { get; set; }

    public short? TimeLimitForDelivery { get; set; }

    public string? SeparatePicklist { get; set; }

    public string? PageBreakStockLocation { get; set; }

    public string? SortStockLocation { get; set; }

    public string? DeliveryPlanCode { get; set; }

    public string? PacklistOnly { get; set; }

    public string? DpVersion { get; set; }

    public string? DefaultTemplate { get; set; }

    public string? SameTemplateInPrint { get; set; }

    public string? ShowWeightVol { get; set; }

    public string? ShowFrieghtDtl { get; set; }

    public string? ShowExtraDesc { get; set; }

    public string? OddsAllianceFlag { get; set; }

    public string? PicklistDeliveryFlag { get; set; }

    public string? ShowDrawingRevision { get; set; }

    public string? ShowComponents { get; set; }

    public string? ShowDiscount { get; set; }

    public string? ShowVat { get; set; }

    public string? ShowTotalVat { get; set; }

    public string? BlankLineBetweenOrderLines { get; set; }

    public string? OfferTemplate { get; set; }

    public string? ShowStoreStockPosition { get; set; }

    public string? ShowNetAmtForEachOrderLine { get; set; }

    public string? DeliveryNonstoredGoods { get; set; }

    public string? PrintDeliveryNote { get; set; }

    public string? WarningQtyLessThanLotsize { get; set; }

    public string? WaybillFormat { get; set; }

    public string? DhlLocktradeDoctype { get; set; }

    public string? CreateCustomerId { get; set; }

    public string? ShowStatisticsNo { get; set; }

    public string? ShowDelDateInPicklistDelnote { get; set; }

    public string? InvoicePackingItem { get; set; }

    public string? StockHandlingPackingItem { get; set; }

    public string? ShowComponentsForDelnote { get; set; }

    public string? ShowIbanForCurrency { get; set; }

    public string? ShowPalletsInPicklist { get; set; }

    public string? UseridAsOurRefInCustomerOrder { get; set; }

    public string? ConsigneeAsCustomerName { get; set; }

    public string? SortPicklistByItemNo { get; set; }

    public string? ShowExtraDescForInternDoc { get; set; }

    public string? AvailableQtyWarningInCo { get; set; }

    public string? OrderLineDisEvenIfPriceListExists { get; set; }

    public string? ShowNoOfPacketsInCo { get; set; }

    public string? AvailQtyWithoutMinBalWarningInCo { get; set; }

    public string? PriceListWarningInCo { get; set; }

    public string? ShowFreeTextInCustOrder { get; set; }

    public string? ShowTotalInOffer { get; set; }

    public string? EditEmailBeforeSend { get; set; }

    public string? ShowTotalPerStatsNo { get; set; }

    public string? ShowItemdescSearch { get; set; }

    public string? ShowZeroQtyLinesInDelnote { get; set; }

    public short? CustDelPrecisionPercent { get; set; }

    public string? LineBetweenOrderLines { get; set; }

    public string? IncludeFullyDelLinesInCoPrint { get; set; }

    public string? WarningIfDelQtyLessThanMinQtyDp { get; set; }

    public string? WarningIfNoSpAtDelivery { get; set; }

    public string? FileOrDbForDeliveryPlan { get; set; }

    public string? AutomaticNotifnForDeliveryPlan { get; set; }

    public string? ShowCustomerNameExtra { get; set; }

    public int? NoOfDaysForDesiredDelDate { get; set; }

    public string? CreatePackingItemsAtDelivery { get; set; }

    public string? EdiCustomerOrder { get; set; }

    public string? SmallboxDbFlag { get; set; }

    public string? PricePerArea { get; set; }

    public string? ShowDualCurrInInv { get; set; }

    public string? PageBreakForInvSummary { get; set; }

    public string? BlankLineInInvAfterYourRef { get; set; }

    public string? ShowTextForDelQty { get; set; }

    public string? ShowUnitOfStockInDelnote { get; set; }

    public string? DemandCategoryMandatoryInCust { get; set; }

    public string? CavityFromCustOrder { get; set; }

    public string? ReserveFictiveItems { get; set; }

    public string? NormalItemsAsTempItems { get; set; }

    public string? ShowComponentsInOrderCfmn { get; set; }

    public string? ShowComponentsInInvoice { get; set; }

    public string? ShowComponentsInDelnote { get; set; }

    public string? ShowPalletNoInDelnote { get; set; }

    public string? ShowPalletNoInInvoice { get; set; }

    public string? ReceiverAddressOption { get; set; }

    public string? MarkAllLinesInDeliveryToCust { get; set; }

    public string? ZeroQtyForPalletsInDelToCust { get; set; }

    public short? AllowableEarlyDeliveryDays { get; set; }

    public short? AllowableLateDeliveryDays { get; set; }

    public short? FreightNoteEx { get; set; }

    public string? ShowWeightVolInInvoice { get; set; }

    public string? AdvInvPerOrderLine { get; set; }

    public string? SetupcostForAllContrOrdLinesInInv { get; set; }

    public string? SetupcostFromOrderInInv { get; set; }

    public string? OnlyValidPriceLists { get; set; }

    public string? IncludeServiceLinesInLineTot { get; set; }

    public string? PlanDelDateByShopCalDate { get; set; }

    public string? ItemNumberAccessories { get; set; }

    public string? EditTemplate { get; set; }

    public string? IncludeInternalInvoiceInStatistics { get; set; }

    public string? IncludeServiceLinesInInvStats { get; set; }

    public string? PaymentTermsDescInEdiFile { get; set; }

    public string? WarningIfPackingStructureMissing { get; set; }

    public string? WarningIfStatisticsNoMissing { get; set; }

    public int? TwimUserId { get; set; }

    public string? DeliveryPrecision { get; set; }

    public string? DocumentationIds { get; set; }

    public string? DocumentUniqueOrdertext { get; set; }

    public decimal? AgentFee { get; set; }

    public decimal? ClearanceFee { get; set; }

    public string? CopyOfferCoToCustomer { get; set; }

    public string? ShowTotalInOrderConfm { get; set; }

    public int? OrderValidDateDays { get; set; }

    public string? SelectFlagDoNotPrintDateInOc { get; set; }

    public short? NoOfWeeksForResvInCreatePacklist { get; set; }

    public string? PreliminaryCo { get; set; }

    public string? ShowCustomerOrderNoInEmailSubject { get; set; }

    public string? ServiceLinesWithinDelnoteInInv { get; set; }

    public short? NoOfDaysAheadResv { get; set; }

    public string? SortByDeliveryLocPallets { get; set; }

    public string? PrintOnlyDualCurrency { get; set; }

    public string? CheckCpGtSp { get; set; }

    public string? ShowTotInclVatInCo { get; set; }

    public string? WarningInCoIfCpIsZero { get; set; }

    public string? CreatePacklistWithoutPackInstr { get; set; }

    public string? ShowDelQtyInOc { get; set; }

    public string? OurDeliveryAddressIdForOffer { get; set; }

    public string? FooterTextIdForOffer { get; set; }

    public string? MinSaleQtyInCoCt { get; set; }
}
