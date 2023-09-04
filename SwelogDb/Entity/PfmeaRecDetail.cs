using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PfmeaRecDetail
{
    public string RecDetailType { get; set; } = null!;

    public short RecDetailCode { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RecDetailDescription { get; set; }

    public string? RecDetailText { get; set; }

    public string? AuditStamp { get; set; }
}
