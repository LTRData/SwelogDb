using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AcElementTable
{
    public decimal ColumnNo { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? ColumnName { get; set; }

    public string? ColumnDesc { get; set; }
}
