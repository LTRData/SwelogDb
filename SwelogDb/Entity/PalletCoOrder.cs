using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletCoOrder
{
    public int RecNo { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? ItemNumber { get; set; }

    public string? ParentItemNumber { get; set; }

    public string? PacklistNumber { get; set; }

    public string? PicklistNumber { get; set; }

    public string? DeliveryNote { get; set; }

    public string? PalletNo { get; set; }

    public string? StoreLocation { get; set; }

    public string? StockPosition { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? QuantityReserved { get; set; }

    public decimal? QuantityIssued { get; set; }

    public string? DeliveryFlag { get; set; }

    public DateTime? DemandDate { get; set; }

    public string? FromWhere { get; set; }

    public short? PicklistDtlLineNo { get; set; }

    public virtual PacklistHeader? PacklistNumberNavigation { get; set; }
}
