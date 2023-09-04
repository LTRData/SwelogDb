using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwOrderDtl
{
    public string PartnerOrderType { get; set; } = null!;

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? OrderKey { get; set; }

    public string? ItemNumber { get; set; }

    public string? GoodsDescription { get; set; }

    public int? GoodsDescriptionTxtid { get; set; }

    public string? GoodsDescriptionFlag { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public decimal? OrderQuantityStockUnit { get; set; }

    public string? UnitOfStock { get; set; }

    public DateTime? DesiredDeliveryDate { get; set; }

    public DateTime? PromisedDeliveryDate { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? OrderedAmount { get; set; }

    public string? VatCode { get; set; }

    public string? TransportModeCode { get; set; }
}
