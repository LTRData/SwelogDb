using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderTextid
{
    public string TextType { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public int OrderTextId1 { get; set; }

    public byte[]? LongText { get; set; }

    public string? AuditStamp { get; set; }
}
