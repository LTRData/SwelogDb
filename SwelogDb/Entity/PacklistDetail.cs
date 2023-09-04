using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PacklistDetail
{
    public string PacklistNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public DateTime DemandDate { get; set; }

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? ItemDesc { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public decimal? NumberPerSmallbox { get; set; }

    public decimal? NumberPerPallet { get; set; }

    public decimal? DeliveredQty { get; set; }

    public decimal? OrderQty { get; set; }

    public string? PackingInstruction { get; set; }

    public string? PicklistNumber { get; set; }

    public DateTime? ActualDeliveryDate { get; set; }

    public string? PalletType { get; set; }

    public decimal? ConversionFactor { get; set; }

    public decimal? BalanceOrderQty { get; set; }

    public decimal? ItemNetWt { get; set; }

    public string? WtUom { get; set; }

    public decimal? ItemNetVol { get; set; }

    public string? VolUom { get; set; }

    public string? Status { get; set; }

    public string? SalesUnit { get; set; }

    public string? ParentItem { get; set; }

    public decimal? ParentQuantity { get; set; }

    public string? AuditStamp { get; set; }

    public short? PicklistDtlLineNo { get; set; }

    public string? StoreLocation { get; set; }

    public string? DpPartConsignment { get; set; }

    public string? Callno { get; set; }

    public virtual PacklistHeader PacklistNumberNavigation { get; set; } = null!;
}
