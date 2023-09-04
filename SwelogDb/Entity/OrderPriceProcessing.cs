using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderPriceProcessing
{
    public string OrderPriceProcessingCode { get; set; } = null!;

    public string? OrderPriceProcessingDesc { get; set; }

    public int? OrderPriceProcessingTxtid { get; set; }

    public string? OrderPriceProcessingFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaderCostPriceProcessingCodeNavigations { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<CustomerOrderHeader> CustomerOrderHeaderSalesPriceProcessingCodeNavigations { get; } = new List<CustomerOrderHeader>();

    public virtual ICollection<OrderEntryTemplate> OrderEntryTemplateCostPriceProcessingCodeNavigations { get; } = new List<OrderEntryTemplate>();

    public virtual ICollection<OrderEntryTemplate> OrderEntryTemplateSalesPriceProcessingCodeNavigations { get; } = new List<OrderEntryTemplate>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaderCostPriceProcessingCodeNavigations { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaderSalesPriceProcessingCodeNavigations { get; } = new List<PurchaseOrderHeader>();
}
