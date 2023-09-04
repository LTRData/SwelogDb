using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WebshopHbCustomerRequestLineArchive
{
    public int RequestSerialNumber { get; set; }

    public int SerialNumber { get; set; }

    public int? OrderLineNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? GoodsDescription { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? Pos { get; set; }

    public string? Marke { get; set; }

    public DateTime? DesiredDeliveryDate { get; set; }

    public string? UnitOfSale { get; set; }

    public string? AuditStamp { get; set; }

    public string? GoodsMarking { get; set; }

    public decimal? Price { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public string? UpdateOrderLine { get; set; }

    public virtual WebshopHbCustomerRequestArchive RequestSerialNumberNavigation { get; set; } = null!;
}
