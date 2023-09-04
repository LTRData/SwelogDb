using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StandardLanguage
{
    public string LanguageText { get; set; } = null!;

    public string? LanguageCode { get; set; }

    public string? AuditStamp { get; set; }
}
