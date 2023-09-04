using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DemandText
{
    public int DemandNo { get; set; }

    public string Language { get; set; } = null!;

    public string? Text1 { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Language LanguageNavigation { get; set; } = null!;
}
