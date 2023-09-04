using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WebshopCustomerRequestLine
{
    public string CustomerId { get; set; } = null!;

    public string RequestNumber { get; set; } = null!;

    public int IdWebshopCustomerRequestLine { get; set; }

    public string? OrderNumber { get; set; }

    public int? OrderLine { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public string? OrderLineType { get; set; }

    public string? Pos { get; set; }

    public string? Marke { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? SalesUnit { get; set; }

    public int? OrderLineStatus { get; set; }

    public string? OrderLineDescription { get; set; }

    public string? AuditStamp { get; set; }
}
