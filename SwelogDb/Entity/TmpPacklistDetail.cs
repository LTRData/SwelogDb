using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpPacklistDetail
{
    public int ProcessId { get; set; }

    public int RowId { get; set; }

    public string? PacklistNumber { get; set; }

    public string? ItemNumber { get; set; }

    public DateTime? DemandDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? OrderLineType { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? PicklistNumber { get; set; }

    public decimal? OrderQty { get; set; }

    public decimal? DeliveredQty { get; set; }

    public decimal? ParentDeliveredQuantity { get; set; }

    public string? ParentItem { get; set; }

    public decimal? ParentQuantity { get; set; }

    public decimal? ParentStockQuantity { get; set; }

    public decimal? QtyOfComponent { get; set; }

    public string? FinalFlag { get; set; }

    public string? ReservationCode { get; set; }

    public string? StoreLocation { get; set; }

    public string? StockPosition { get; set; }

    public string? PartnerId { get; set; }

    public string? PalletArray { get; set; }

    public string? PalletQtyArray { get; set; }

    public string? Userid { get; set; }

    public string? Workstation { get; set; }

    public decimal? GrossWeight { get; set; }

    public string? PackingItem { get; set; }

    public string? YourDeliveryNote { get; set; }

    public bool? CustomerConsignation { get; set; }

    public string? DoNotIncludeInIntrastat { get; set; }

    public string? CocLineText { get; set; }

    public string? EdiPalletArray { get; set; }
}
