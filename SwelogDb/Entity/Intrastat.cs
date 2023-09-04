using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Intrastat
{
    public int SerealNo { get; set; }

    public string IntrastatCode { get; set; } = null!;

    public string EuCode { get; set; } = null!;

    public DateTime? ArrivalDate { get; set; }

    public string? TariffCode { get; set; }

    public string? TransactionType { get; set; }

    public string? TransportMode { get; set; }

    public decimal? NetWeight { get; set; }

    public string? OtherQuantity { get; set; }

    public string? OrderNumber { get; set; }

    public decimal? StatValue { get; set; }

    public string? AuditStamp { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? OrderType { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? GoodsEntryNo { get; set; }

    public string? ItemNumber { get; set; }

    public string? InvoiceType { get; set; }

    public string? InvoiceSeries { get; set; }

    public decimal? InvoiceNo { get; set; }
}
