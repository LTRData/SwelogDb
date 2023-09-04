using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderText
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public string DeliveryAddressId { get; set; } = null!;

    public string TextType { get; set; } = null!;

    public string TextKey { get; set; } = null!;

    public string OrderTextId { get; set; } = null!;

    public string DocumentId { get; set; } = null!;

    public string? LanguageCode { get; set; }

    public string? TextIndicator { get; set; }

    public byte[]? OrderLongText { get; set; }

    public string? AuditStamp { get; set; }

    public string? LongText { get; set; }

    public string? InvoiceNo { get; set; }

    public short? LineNo { get; set; }
}
