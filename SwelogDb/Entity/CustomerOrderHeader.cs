using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerOrderHeader
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? PartnerId { get; set; }

    public string? OeTemplateId { get; set; }

    public string? NextManualFunction { get; set; }

    public string? DocumentationId { get; set; }

    public string? OrderBackPermissionFlag { get; set; }

    public string? PackingReceiptOption { get; set; }

    public string? IndividualInvoices { get; set; }

    public string? InvoiceNumberSeries { get; set; }

    public string? AdvanceInvoiceNumberSeries { get; set; }

    public string? OrderEntryScreenOption { get; set; }

    public short? OrderLineNumberStep { get; set; }

    public string? DifferentDeliveryDateFlag { get; set; }

    public string? DifferentWarehouseOption { get; set; }

    public string? OldOrderLineCopyOption { get; set; }

    public string? ItemNumberType { get; set; }

    public string? OrderQuantityChangeType { get; set; }

    public string? InvAccountChangeOption { get; set; }

    public string? OrderPricingOption { get; set; }

    public string? SalesPriceProcessingCode { get; set; }

    public string? CostPriceEntryOption { get; set; }

    public string? CostPriceDisplayOption { get; set; }

    public string? CostPriceProcessingCode { get; set; }

    public string? OrderLineDiscChangeFlag { get; set; }

    public short? DiscountProcessingCode { get; set; }

    public string? MultipleDeliveryOption { get; set; }

    public string? AvailablityCheckFlag { get; set; }

    public string? QuantityAllocationFlag { get; set; }

    public short? QuantityAllocationMethod { get; set; }

    public string? MannualDueDateOption { get; set; }

    public string? CreditControlOption { get; set; }

    public string? CreditControlTimeOption { get; set; }

    public string? OldOrderNumber { get; set; }

    public DateTime? OldOrderDate { get; set; }

    public string? PartnerOwnOrderNo { get; set; }

    public string? ProjectNumber { get; set; }

    public decimal? OrderTotalWeight { get; set; }

    public decimal? OrderTotalVolume { get; set; }

    public decimal? OrderTotalAmount { get; set; }

    public string? FinalDeliveryFlag { get; set; }

    public string? OrderStatus { get; set; }

    public DateTime? OrderValidDate { get; set; }

    public DateTime? OrderRequiredDate { get; set; }

    public DateTime? OrderPromisedDate { get; set; }

    public int? MailingAddressNo { get; set; }

    public int? ElectronicAddressNo { get; set; }

    public string? PartnerCategory { get; set; }

    public string? PartnerClassCode { get; set; }

    public string? PartnerAccountCode { get; set; }

    public string? CustomerSupplierNo { get; set; }

    public string? CurrencyCode { get; set; }

    public string? LanguageCode { get; set; }

    public string? ExportImportStatus { get; set; }

    public string? DateFormat { get; set; }

    public string? InspectionRequiredFlag { get; set; }

    public string? OurReference { get; set; }

    public string? TheirReference { get; set; }

    public string? GoodsReference { get; set; }

    public string? InvoiceReference { get; set; }

    public string? PartnerDiscountGroupCode { get; set; }

    public decimal? PartnerDiscountPercentile { get; set; }

    public string? PriceListId { get; set; }

    public string? FreightTerms { get; set; }

    public string? DefaultDeliveryAddressId { get; set; }

    public string? DeliveryLabelId { get; set; }

    public string? PackingCode { get; set; }

    public short? TransportTimeInDays { get; set; }

    public short? AllowableEarlyDeliveryDays { get; set; }

    public short? AllowableLateDeliveryDays { get; set; }

    public string? DeliveryTermsCode { get; set; }

    public string? TransportModeCode { get; set; }

    public string? EuTransportModeCode { get; set; }

    public string? InvoicePaymentTerm { get; set; }

    public string? InterestInvoiceOption { get; set; }

    public string? IntInvoicePaymentTerm { get; set; }

    public string? IndividualInvoiceFlag { get; set; }

    public string? CollectiveInvoiceFlag { get; set; }

    public string? FactoringFlag { get; set; }

    public string? PartnerToFactor { get; set; }

    public string? FreeDeliveryMonthFlag { get; set; }

    public string? InvoiceChargeOption { get; set; }

    public string? DueDateGenerationMethod { get; set; }

    public string? VatCode { get; set; }

    public decimal? OrderTotalDiscount { get; set; }

    public decimal? PostageCharges { get; set; }

    public decimal? FreightCharges { get; set; }

    public decimal? PackagingCharges { get; set; }

    public decimal? OrderContribution { get; set; }

    public string? PriorityCode { get; set; }

    public string? SalesmanCode { get; set; }

    public string? BonusGroupCode { get; set; }

    public string? CommissionGroup { get; set; }

    public string? OverridingCommisionCode { get; set; }

    public string? InvoiceRoutingReference { get; set; }

    public string? MarketCode { get; set; }

    public string? TerritoryCode { get; set; }

    public string? DefaultWarehouseId { get; set; }

    public string? EuLabourCode { get; set; }

    public string? AContoInvoiceFlag { get; set; }

    public string? GoodsMarking { get; set; }

    public string? CustomerTextFlag { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? ConfirmationDate { get; set; }

    public string? YourReference { get; set; }

    public DateTime? YourReferenceDate { get; set; }

    public decimal? OfferSuccessRate { get; set; }

    public string? DoNotPrintPriceInOrderConfmn { get; set; }

    public string? EdiOrder { get; set; }

    public string? EdiAgreementId { get; set; }

    public string? EdiBillToCustomerId { get; set; }

    public string? EdiBillToCustomerName { get; set; }

    public string? EdiBillToPostCode { get; set; }

    public string? EdiBillToCity { get; set; }

    public string? EdiBillToCountryCode { get; set; }

    public string? EdiBillToVatRegNo { get; set; }

    public string? EdiBillToCustomerAddress { get; set; }

    public string? FreightPayType { get; set; }

    public string? InvoiceAddressAsOrderAddress { get; set; }

    public string? SellingPriceInclSetupCost { get; set; }

    public string? CustFreeCode { get; set; }

    public string? LineConfirmedUserid { get; set; }

    public DateTime? LineConfirmedDate { get; set; }

    public string? OurDeliveryAddressId { get; set; }

    public string? EdiWorkflowRefIc1 { get; set; }

    public string? EdiAccountPd1 { get; set; }

    public string? EdiPurchaserPd2 { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public string? DoNotPrintDateInOc { get; set; }

    public string? PreliminaryCo { get; set; }

    public string? SdsLanguageCode { get; set; }

    public int? PartId { get; set; }

    public string? CustomerConsignation { get; set; }

    public bool? CoProduced { get; set; }

    public string? CreatedFrom { get; set; }

    public string? WebshopUser { get; set; }

    public virtual OrderPriceProcessing? CostPriceProcessingCodeNavigation { get; set; }

    public virtual OrderCreditControl? CreditControlTimeOptionNavigation { get; set; }

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual ICollection<CustomerOrderDtl> CustomerOrderDtls { get; } = new List<CustomerOrderDtl>();

    public virtual DeliveryLabel? DeliveryLabel { get; set; }

    public virtual DeliveryTerm? DeliveryTermsCodeNavigation { get; set; }

    public virtual EuLabour? EuLabourCodeNavigation { get; set; }

    public virtual EuTransportCode? EuTransportModeCodeNavigation { get; set; }

    public virtual FreightTerm? FreightTermsNavigation { get; set; }

    public virtual InterestPaymentTerm? IntInvoicePaymentTermNavigation { get; set; }

    public virtual InvoicePaymentTerm? InvoicePaymentTermNavigation { get; set; }

    public virtual OrderItemType? ItemNumberTypeNavigation { get; set; }

    public virtual Language? LanguageCodeNavigation { get; set; }

    public virtual MailingAddress? MailingAddressNoNavigation { get; set; }

    public virtual Market? MarketCodeNavigation { get; set; }

    public virtual OrderFunction? NextManualFunctionNavigation { get; set; }

    public virtual Customer? Partner { get; set; }

    public virtual CustomerCategory? PartnerCategoryNavigation { get; set; }

    public virtual CustomerDiscountGroup? PartnerDiscountGroupCodeNavigation { get; set; }

    public virtual CustomerPriority? PriorityCodeNavigation { get; set; }

    public virtual OrderPriceProcessing? SalesPriceProcessingCodeNavigation { get; set; }

    public virtual Territory? TerritoryCodeNavigation { get; set; }

    public virtual Tax? VatCodeNavigation { get; set; }
}
