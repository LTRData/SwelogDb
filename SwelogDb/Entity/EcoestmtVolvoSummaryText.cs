using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoestmtVolvoSummaryText
{
    public string SummaryIdentifier { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string? SummaryText { get; set; }
}
