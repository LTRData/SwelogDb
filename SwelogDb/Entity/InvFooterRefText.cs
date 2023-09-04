using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InvFooterRefText
{
    public string InvFooterRefTextId { get; set; } = null!;

    public string? LanguageCode { get; set; }

    public string? RefDesc { get; set; }

    public string? RefText { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Language? LanguageCodeNavigation { get; set; }
}
