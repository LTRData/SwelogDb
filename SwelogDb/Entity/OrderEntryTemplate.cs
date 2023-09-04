using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderEntryTemplate
{
    public string OrderEntryTemplateId { get; set; } = null!;

    public string? OrderEntryTemplateName { get; set; }

    public string? OrderType { get; set; }

    public string? NextMannualFunction { get; set; }

    public string? DocumentationId { get; set; }

    public string? OrderBackPermissionFlag { get; set; }

    public string? PackingReceiptOption { get; set; }

    public string? IndividualInvoiceFlag { get; set; }

    public string? OrderNumberSeries { get; set; }

    public string? InvoiceNumberSeries { get; set; }

    public string? AdvInvoiceNumberSeries { get; set; }

    public string? QuotationNumberSeries { get; set; }

    public string? OrderEntryScreenOption { get; set; }

    public short? OrderLineNumberStep { get; set; }

    public string? DifferentDeliveryDateFlag { get; set; }

    public string? DifferentWarehouseOption { get; set; }

    public string? OldOrderLineCopyOption { get; set; }

    public string? ItemNumberType { get; set; }

    public string? OrderQuantityChangeType { get; set; }

    public string? InvAccountChangeOption { get; set; }

    public string? OrderPricingOption { get; set; }

    public string? PriceHistoryDisplayFlag { get; set; }

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

    public string? ProjectNumber { get; set; }

    public string? CustomerTextFlag { get; set; }

    public string? ItemTextFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? DeliveryDateStatus { get; set; }

    public int? TempDescTxtid { get; set; }

    public string? TempDescTxtidFlag { get; set; }

    public virtual OrderPriceProcessing? CostPriceProcessingCodeNavigation { get; set; }

    public virtual OrderCreditControl? CreditControlTimeOptionNavigation { get; set; }

    public virtual OrderItemType? ItemNumberTypeNavigation { get; set; }

    public virtual OrderFunction? NextMannualFunctionNavigation { get; set; }

    public virtual OrderPriceProcessing? SalesPriceProcessingCodeNavigation { get; set; }
}
