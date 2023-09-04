using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReportOption
{
    public string ReportId { get; set; } = null!;

    public string Language { get; set; } = null!;

    public string FieldsToChoose { get; set; } = null!;

    public string? AlternateDatawindow { get; set; }

    public int AddSelectIndex { get; set; }
}
