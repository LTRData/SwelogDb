using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderLineText
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public string TextType { get; set; } = null!;

    public string TextKey { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string TextIndicator { get; set; } = null!;

    public string DocumentId { get; set; } = null!;

    public string OrderTextId { get; set; } = null!;

    public string? OrderLongText { get; set; }

    public string? AuditStamp { get; set; }
}
