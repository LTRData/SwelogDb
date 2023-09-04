using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwWebshopCustomerRequestLine
{
    public string? CustomerId { get; set; }

    public string? RequestNumber { get; set; }

    public string? PartnerOwnOrderNo { get; set; }

    public int IdWebshopCustomerRequestLine { get; set; }

    public string OrderType { get; set; } = null!;

    public string? OrderNumber { get; set; }

    public int? OrderLineNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? GoodsDescription { get; set; }

    public int? OrderLineType { get; set; }

    public string? Pos { get; set; }

    public string? Marke { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? UnitOfSale { get; set; }

    public int? OrderLineStatus { get; set; }

    public string SwSource { get; set; } = null!;

    public int? RequestStatus { get; set; }

    public int LineColor { get; set; }

    public string LineStatusText { get; set; } = null!;
}
