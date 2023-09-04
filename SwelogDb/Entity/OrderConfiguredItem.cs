using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderConfiguredItem
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public int OrderLineNumber { get; set; }

    public int OrderLineNumberSub { get; set; }

    public string ParentItemNumber { get; set; } = null!;

    public string ComponentItemNumber { get; set; } = null!;

    public decimal? ComponentItemPrice { get; set; }

    public string? ComponentPriceUnit { get; set; }

    public decimal? ComponentItemQuantity { get; set; }

    public string? ComponentQuantityUnit { get; set; }

    public string? AuditStamp { get; set; }
}
