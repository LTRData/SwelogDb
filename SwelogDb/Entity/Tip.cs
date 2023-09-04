using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Tip
{
    public int TipId { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? TipText { get; set; }

    public string? Module { get; set; }

    public string? SubModule { get; set; }

    public string? HelpFileName { get; set; }

    public string? VersionNumber { get; set; }

    public DateTime? CreatedDate { get; set; }
}
