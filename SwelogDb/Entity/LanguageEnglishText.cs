using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class LanguageEnglishText
{
    public string LanEng { get; set; } = null!;

    public decimal? LanEngLen { get; set; }

    public string? Dwname { get; set; }

    public string? LanSwe { get; set; }

    public string? AuditStamp { get; set; }
}
