using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AcReport
{
    public short ReportId { get; set; }

    public string CriteriaDwo { get; set; } = null!;

    public string ReportDwo { get; set; } = null!;

    public string ReportName { get; set; } = null!;

    public string? FilterColumns { get; set; }

    public string? RetrieveColumns { get; set; }

    public string? SortColumns { get; set; }

    public string ModuleId { get; set; } = null!;

    public string? AdditionalWins { get; set; }

    public string? SortLangColumns { get; set; }

    public string LanguageCode { get; set; } = null!;
}
