using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ContractOrderItem
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public short? OrderLineNumber { get; set; }

    public string? OrderLineType { get; set; }

    public string? DeliveryAddressId { get; set; }

    public DateTime? DemandDate { get; set; }

    public string? UnitOfSale { get; set; }

    public string? UnitOfStock { get; set; }

    public decimal? SellingPrice { get; set; }

    public string? ItemDiscountGroupCode { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? SetupPrice { get; set; }

    public string? VatCode { get; set; }

    public string? GoodsMarking { get; set; }

    public short? PriceUnit { get; set; }

    public decimal? SaleToStockFactor { get; set; }

    public decimal? OrderQuantity { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public string? DirectDeliveryFlag { get; set; }

    public string? OrderLineStatus { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? MinDelQty { get; set; }

    public decimal? TotalOrderQty { get; set; }

    public string? DeladdrFixedYn { get; set; }

    public string? DeliveryStatus { get; set; }

    public virtual ItemDiscountGroup? ItemDiscountGroupCodeNavigation { get; set; }

    public virtual ContractOrderHeader Order { get; set; } = null!;
}
