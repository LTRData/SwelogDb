using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpPacklistDetailFictive
{
    public int RowId { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? PacklistNumber { get; set; }

    public string? PicklistNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? OrderLineType { get; set; }

    public decimal? OrderQty { get; set; }

    public decimal? DeliveredQty { get; set; }

    public decimal? ParentDeliveredQuantity { get; set; }

    public string? ParentItem { get; set; }

    public decimal? ParentQuantity { get; set; }

    public decimal? ParentStockQuantity { get; set; }

    public decimal? QtyOfComponent { get; set; }

    public string? FinalFlag { get; set; }

    public string? StoreLocation { get; set; }

    public string? StockPosition { get; set; }

    public string? PartnerId { get; set; }

    public decimal? ConversionFactor { get; set; }

    public string? CustomerOrderNumber { get; set; }
}
