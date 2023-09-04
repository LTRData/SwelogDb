using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ContractOrderHeader
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? CustomerNo { get; set; }

    public string? CustomerOrderNo { get; set; }

    public string? OeTemplateId { get; set; }

    public string? ContractOrderType { get; set; }

    public string? PrognosOrderNumber { get; set; }

    public string? DocumentationId { get; set; }

    public string? InvoiceNumberSeries { get; set; }

    public string? CostPriceEntryOption { get; set; }

    public string? CostPriceDisplayOption { get; set; }

    public int? MailingAddressNo { get; set; }

    public int? ElectronicAddressNo { get; set; }

    public string? DeliveryAddressId { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? OrderStatus { get; set; }

    public string? PartnerCategory { get; set; }

    public string? PartnerClassCode { get; set; }

    public string? CurrencyCode { get; set; }

    public string? LanguageCode { get; set; }

    public string? ExportImportStatus { get; set; }

    public string? OurReference { get; set; }

    public string? GoodsReference { get; set; }

    public string? InvoiceReference { get; set; }

    public string? PartnerDiscountGroupCode { get; set; }

    public decimal? PartnerDiscountPercentile { get; set; }

    public string? PriceListId { get; set; }

    public string? FreightTerms { get; set; }

    public string? DeliveryTermsCode { get; set; }

    public string? TransportModeCode { get; set; }

    public string? EuTransportModeCode { get; set; }

    public string? InvoicePaymentTerm { get; set; }

    public string? IndividualInvoiceFlag { get; set; }

    public string? AContoInvoiceFlag { get; set; }

    public string? FactoringFlag { get; set; }

    public string? PartnerToFactor { get; set; }

    public string? FreeDeliveryMonthFlag { get; set; }

    public string? InvoiceChargeOption { get; set; }

    public string? VatCode { get; set; }

    public string? PriorityCode { get; set; }

    public string? SalesmanCode { get; set; }

    public string? InvoiceRoutingReference { get; set; }

    public string? MarketCode { get; set; }

    public string? TerritoryCode { get; set; }

    public string? EuLabourCode { get; set; }

    public string? CustomerTextFlag { get; set; }

    public string? ItemTextFlag { get; set; }

    public string? IndividualPickingListFlag { get; set; }

    public string? YourReference { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? ConsigLocation { get; set; }

    public string? FreightPayType { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<ContractOrderItem> ContractOrderItems { get; } = new List<ContractOrderItem>();

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual Customer? CustomerNoNavigation { get; set; }

    public virtual DeliveryTerm? DeliveryTermsCodeNavigation { get; set; }

    public virtual EuLabour? EuLabourCodeNavigation { get; set; }

    public virtual EuTransportCode? EuTransportModeCodeNavigation { get; set; }

    public virtual FreightTerm? FreightTermsNavigation { get; set; }

    public virtual InvoicePaymentTerm? InvoicePaymentTermNavigation { get; set; }

    public virtual Language? LanguageCodeNavigation { get; set; }

    public virtual MailingAddress? MailingAddressNoNavigation { get; set; }

    public virtual Market? MarketCodeNavigation { get; set; }

    public virtual CustomerCategory? PartnerCategoryNavigation { get; set; }

    public virtual CustomerDiscountGroup? PartnerDiscountGroupCodeNavigation { get; set; }

    public virtual CustomerPriority? PriorityCodeNavigation { get; set; }

    public virtual Territory? TerritoryCodeNavigation { get; set; }

    public virtual Tax? VatCodeNavigation { get; set; }
}
