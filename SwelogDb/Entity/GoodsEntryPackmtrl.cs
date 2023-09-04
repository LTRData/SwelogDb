using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GoodsEntryPackmtrl
{
    public int RecNo { get; set; }

    public string? GoodsentryNo { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? CustomerId { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? DeliveryQty { get; set; }

    public decimal? RecvdQty { get; set; }

    public decimal? ApprovedQty { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? StoreLocFrom { get; set; }

    public string? StoreLocTo { get; set; }

    public string? StockPosFrom { get; set; }

    public string? StockPosTo { get; set; }

    public string? FinalFlag { get; set; }

    public string? PackMtrlFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? InvoiceFlag { get; set; }

    public string? InvoiceSeries { get; set; }

    public decimal? InvoiceNo { get; set; }
}
