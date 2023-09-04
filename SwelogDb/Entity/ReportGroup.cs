using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportGroup
{
    public string ReportIdPrefix { get; set; } = null!;

    public string LanguageCode { get; set; } = null!;

    public string? ReportGroupName { get; set; }
}
