using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderGeneralText
{
    public string TextType { get; set; } = null!;

    public string TextKey { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string TextIndicator { get; set; } = null!;

    public string DocumentId { get; set; } = null!;

    public int OrderTextId { get; set; }

    public string? OrderTextDesc { get; set; }

    public string? AuditStamp { get; set; }
}
