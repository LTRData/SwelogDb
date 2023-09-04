using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderSpecificFreeText
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string TextType { get; set; } = null!;

    public string? FreeTextKey { get; set; }

    public string? LanguageCode { get; set; }

    public string? FreeTextLines { get; set; }

    public string? AuditStamp { get; set; }
}
