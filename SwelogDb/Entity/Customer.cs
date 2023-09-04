using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Customer
{
    public string CustomerId { get; set; } = null!;

    public string? CustomerName { get; set; }

    public int? CustomerNameTxtid { get; set; }

    public string? CustomerNameFlag { get; set; }

    public string? CustomerStatusCode { get; set; }

    public string? CustomerKey { get; set; }

    public string? CustomerSearchId { get; set; }

    public string? CustomerCategory { get; set; }

    public string? CustomerClassCode { get; set; }

    public decimal? CustomerGrade { get; set; }

    public string? PriorityCode { get; set; }

    public decimal? CustomerCreditLimit1 { get; set; }

    public decimal? CustomerCreditLimit2 { get; set; }

    public decimal? CustomerCreditLimit3 { get; set; }

    public decimal? CustomerCreditLimit4 { get; set; }

    public int? CustMailingAddressNo { get; set; }

    public int? CustElectronicAddress { get; set; }

    public string? OurReference { get; set; }

    public string? CustomerReference { get; set; }

    public string? GoodsReference { get; set; }

    public string? InvoiceReference { get; set; }

    public string? SalesmanCode { get; set; }

    public string? LanguageCode { get; set; }

    public string? CurrencyCode { get; set; }

    public string? MarketCode { get; set; }

    public string? TerritoryCode { get; set; }

    public string? EuCountryCode { get; set; }

    public string? EuLabourCode { get; set; }

    public string? VatRegistrationNumber { get; set; }

    public string? CustomerExportStatus { get; set; }

    public string? CustomerDiscountGroupCode { get; set; }

    public decimal? DiscountPercentile { get; set; }

    public string? BonusGroupCode { get; set; }

    public string? CommissionGroup { get; set; }

    public string? OverridingCommisionCode { get; set; }

    public string? CustomerAccountCode { get; set; }

    public string? DefaultOrderType { get; set; }

    public string? InterestInvoiceOption { get; set; }

    public string? IndividualInvoiceFlag { get; set; }

    public string? CollectiveInvoiceFlag { get; set; }

    public string? ContoInvoiceFlag { get; set; }

    public string? InvoiceChargeOption { get; set; }

    public string? InvoiceRoutingReference { get; set; }

    public string? PaymentDemandCategory { get; set; }

    public string? FreeDeliveryMonthFlag { get; set; }

    public string? DueDateGenerationMethod { get; set; }

    public string? ContractOrderFlag { get; set; }

    public string? DateFormat { get; set; }

    public string? OrderAcknowPrintFlag { get; set; }

    public string? PickingListPrintFlag { get; set; }

    public string? DeliveryNotePrintFlag { get; set; }

    public short? TransportTimeInDays { get; set; }

    public short? AllowableEarlyDeliveryDays { get; set; }

    public short? AllowableLateDeliveryDays { get; set; }

    public string? CustomerFactoring { get; set; }

    public string? CustomerToFactor { get; set; }

    public string? CustomerSupplierNo { get; set; }

    public string? PaymentTermCustInvoice { get; set; }

    public string? PaymentTermCustIntInvoice { get; set; }

    public string? FreightTerms { get; set; }

    public string? DeliveryTermsCode { get; set; }

    public string? TransportModeCode { get; set; }

    public string? EuTransportModeCode { get; set; }

    public string? DefaultDeliveryAddressId { get; set; }

    public string? DeliveryLabelId { get; set; }

    public string? PackingCode { get; set; }

    public string? DefaultWarehouseId { get; set; }

    public string? VatCode { get; set; }

    public decimal? OrderBalance { get; set; }

    public decimal? OrderAmountTotal { get; set; }

    public decimal? OrderQuantity { get; set; }

    public decimal? OfferBalance { get; set; }

    public decimal? OfferAmountTotal { get; set; }

    public decimal? OfferQuantity { get; set; }

    public decimal? InvoiceAmountCurrentPeriod { get; set; }

    public decimal? InvoiceAmountCurrentYear { get; set; }

    public decimal? InvoiceAmountLastYear { get; set; }

    public decimal? InvAmountYearBeforeLast { get; set; }

    public short? NoOfDueDateCurrPeriod { get; set; }

    public short? NoOfDueDatesCurrentYear { get; set; }

    public short? ReceiptInvoiceCurrPeriod { get; set; }

    public short? NoOfReceiptInvCurrYear { get; set; }

    public short? NumberOfPaydaysCurrPeriod { get; set; }

    public short? NumberOfPaydaysCurrYear { get; set; }

    public decimal? Receivable { get; set; }

    public decimal? Outstanding { get; set; }

    public decimal? InterestAmountNotInvoiced { get; set; }

    public decimal? ProfitAmountCurrentPeriod { get; set; }

    public decimal? ProfitAmountCurrentYear { get; set; }

    public decimal? NoOfProfitCurrentPeriod { get; set; }

    public decimal? NumberOfProfitCurrYear { get; set; }

    public DateTime? LastPurchaseDate { get; set; }

    public DateTime? LatestPaymentDate { get; set; }

    public decimal? NumberOfBuyingWeeks { get; set; }

    public decimal? BuyingFrequencyTotal { get; set; }

    public string? PriceListId1 { get; set; }

    public string? PriceListId2 { get; set; }

    public string? PriceListId3 { get; set; }

    public string? PriceListId4 { get; set; }

    public string? PriceListId5 { get; set; }

    public string? OeTemplateId { get; set; }

    public string? AuditStamp { get; set; }

    public string? GoodsMarking { get; set; }

    public decimal? CreditAmount { get; set; }

    public decimal? CurrencyDifference { get; set; }

    public short? NumberOfInvoices { get; set; }

    public string? ModeOfPayment { get; set; }

    public decimal? VatPercentage { get; set; }

    public decimal? DelayIntPerc { get; set; }

    public decimal? DemandDays1 { get; set; }

    public decimal? DemandDays2 { get; set; }

    public decimal? DemandDays3 { get; set; }

    public decimal? CollectDays { get; set; }

    public decimal? RespiteDays { get; set; }

    public decimal? CustomerDebtAmount { get; set; }

    public short? PeriodNoOfPaidInv { get; set; }

    public decimal? PeriodSalesAmount { get; set; }

    public decimal? PeriodInvIntAmt { get; set; }

    public decimal? PeriodDisAmt { get; set; }

    public decimal? PeriodCntrbnAmt { get; set; }

    public short? NextPrdNoOfInv { get; set; }

    public short? NextPrdNoOfPaidInv { get; set; }

    public decimal? NextPrdSalesAmount { get; set; }

    public short? NextPrdNoOfDueDates { get; set; }

    public short? NextPrdNoOfPayDays { get; set; }

    public decimal? NextPrdInvIntAmt { get; set; }

    public decimal? NextPrdDisAmt { get; set; }

    public decimal? NextPrdProfitAmt { get; set; }

    public decimal? NextPrdCntrbnAmt { get; set; }

    public short? LastYrNoOfInv { get; set; }

    public short? LastYrNoOfPaidInv { get; set; }

    public decimal? LastYrSalesAmount { get; set; }

    public short? LastYrNoOfDueDates { get; set; }

    public short? LastYrNoOfPayDays { get; set; }

    public decimal? LastYrNoInvIntAmt { get; set; }

    public decimal? LastYrDisAmt { get; set; }

    public decimal? LastYrProfitAmt { get; set; }

    public decimal? LastYrCntrbnAmt { get; set; }

    public short? YrBefLastNoOfInv { get; set; }

    public short? YrBefLastNoOfPaidInv { get; set; }

    public decimal? YrBefLastSalesAmount { get; set; }

    public short? YrBefLastOfDueDates { get; set; }

    public short? YrBefLastOfPayDays { get; set; }

    public decimal? YrBefLastInvIntAmt { get; set; }

    public decimal? YrBefLastDisAmt { get; set; }

    public decimal? YrBefLastProfitAmt { get; set; }

    public decimal? YrBefLastCntrbnAmt { get; set; }

    public short? ThisYrNoOfPaidInv { get; set; }

    public decimal? ThisYrSalesAmount { get; set; }

    public decimal? ThisYrInvIntAmt { get; set; }

    public decimal? ThisYrDisAmt { get; set; }

    public decimal? ThisYrCntrbnAmt { get; set; }

    public string? ItemNumberType { get; set; }

    public decimal? ServiceChargePercentage { get; set; }

    public decimal? BlockAmountPercentage { get; set; }

    public string? CustomerType { get; set; }

    public decimal? AverageCollectionPeriod { get; set; }

    public int? AddressLabelColourCode { get; set; }

    public string? CrmBranch { get; set; }

    public string? CrmCategory1 { get; set; }

    public string? CrmCategory2 { get; set; }

    public string? CrmCategory3 { get; set; }

    public string? CrmCategory4 { get; set; }

    public string? CrmCategory5 { get; set; }

    public string? CrmCategory6 { get; set; }

    public string? FreeText { get; set; }

    public string? AlloyInvoiceFlag { get; set; }

    public string? FreightCollectAddress { get; set; }

    public string? PackMtrlFlag { get; set; }

    public string? PackMtrlStoreLoc { get; set; }

    public decimal? InvAmtLimitForSetupCost { get; set; }

    public decimal? InvChargeForSetupCost { get; set; }

    public string? CustomerNameExtra { get; set; }

    public string? DoNotPrintPriceInOrderConfmn { get; set; }

    public string? EdiCustomerId { get; set; }

    public string? BankAccountNo { get; set; }

    public string? InvFooterRefTextId { get; set; }

    public string? CustInvReceiverName { get; set; }

    public string? CustInvReceiverNameExtra { get; set; }

    public int? CustInvMailingAddressNo { get; set; }

    public int? CustInvElectronicAddress { get; set; }

    public string? EdiAgreementId { get; set; }

    public string? SelfBillingInvoice { get; set; }

    public string? ScrapInvoiceFlag { get; set; }

    public decimal? RevalPercForCustRet { get; set; }

    public string? FreightPayType { get; set; }

    public short? CustDelPrecisionPercent { get; set; }

    public string? SellingPriceInclSetupCost { get; set; }

    public string? CustFreeCode { get; set; }

    public string? DeliveryCustomer { get; set; }

    public short? NoOfDecimalsInInv { get; set; }

    public short? InternalLeadTime { get; set; }

    public string? OurDeliveryAddressId { get; set; }

    public string? CreateFreightNote { get; set; }

    public string? WebshopPassword { get; set; }

    public int? DunsNumber { get; set; }

    public string? PmsCode { get; set; }

    public DateTime? LastChangedDate { get; set; }

    public string? LastChangedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public decimal? FreightLimit { get; set; }

    public string? InvRoundingFlag { get; set; }

    public decimal? MaxDebtBc { get; set; }

    public string? PackMtrlInEdiInv { get; set; }

    public string? VatRegistrationNumber2 { get; set; }

    public string? EdiCustUniqueNumberSeries { get; set; }

    public string? EdiCustomerPrefix { get; set; }

    public DateTime? CategoryChangedDate { get; set; }

    public string? Emcs { get; set; }

    public string? EdiGoodsRecvId { get; set; }

    public string? ShowEdiPalletNoInDelnote { get; set; }

    public string? ShowStatisticsNo { get; set; }

    public string? ShowTotalPerStatsNo { get; set; }

    public string? ShowWeightVolInInvoice { get; set; }

    public string? AlloyTextInInv { get; set; }

    public string? PalletLabel { get; set; }

    public virtual ICollection<ChangeCustomerArticle> ChangeCustomerArticles { get; } = new List<ChangeCustomerArticle>();

    public virtual ICollection<ContractOrderHeader> ContractOrderHeaders { get; } = new List<ContractOrderHeader>();

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual ICollection<CustInvHdr> CustInvHdrs { get; } = new List<CustInvHdr>();

    public virtual ICollection<CustInvPay> CustInvPays { get; } = new List<CustInvPay>();

    public virtual MailingAddress? CustMailingAddressNoNavigation { get; set; }

    public virtual ICollection<CustomerArticle> CustomerArticles { get; } = new List<CustomerArticle>();

    public virtual ICollection<CustomerDeliveryAddress> CustomerDeliveryAddresses { get; } = new List<CustomerDeliveryAddress>();

    public virtual CustomerDiscountGroup? CustomerDiscountGroupCodeNavigation { get; set; }

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaders { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<CustomerReference> CustomerReferences { get; } = new List<CustomerReference>();

    public virtual ICollection<CustomerStatistic> CustomerStatistics { get; } = new List<CustomerStatistic>();

    public virtual CustomerStatus? CustomerStatusCodeNavigation { get; set; }

    public virtual DeliveryLabel? DeliveryLabel { get; set; }

    public virtual DeliveryTerm? DeliveryTermsCodeNavigation { get; set; }

    public virtual EuTransportCode? EuTransportModeCodeNavigation { get; set; }

    public virtual FreightTerm? FreightTermsNavigation { get; set; }

    public virtual OrderItemType? ItemNumberTypeNavigation { get; set; }

    public virtual ICollection<ItemPackingInstruction> ItemPackingInstructions { get; } = new List<ItemPackingInstruction>();

    public virtual Language? LanguageCodeNavigation { get; set; }

    public virtual Market? MarketCodeNavigation { get; set; }

    public virtual PaymentModeIn? ModeOfPaymentNavigation { get; set; }

    public virtual ICollection<NewDeliveryPlanHdr> NewDeliveryPlanHdrs { get; } = new List<NewDeliveryPlanHdr>();

    public virtual ICollection<PacklistHeader> PacklistHeaders { get; } = new List<PacklistHeader>();

    public virtual ICollection<PicklistHeader> PicklistHeaders { get; } = new List<PicklistHeader>();

    public virtual CustomerPriority? PriorityCodeNavigation { get; set; }

    public virtual Salesman? SalesmanCodeNavigation { get; set; }

    public virtual ICollection<StoreLocation> StoreLocations { get; } = new List<StoreLocation>();

    public virtual ICollection<TemporaryDeliveryAddress> TemporaryDeliveryAddresses { get; } = new List<TemporaryDeliveryAddress>();

    public virtual Territory? TerritoryCodeNavigation { get; set; }

    public virtual Tax? VatCodeNavigation { get; set; }
}
