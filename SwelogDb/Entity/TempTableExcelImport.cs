using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TempTableExcelImport
{
    public string? CharCol1 { get; set; }

    public string? CharCol2 { get; set; }

    public string? CharCol3 { get; set; }

    public decimal? NumCol1 { get; set; }

    public decimal? NumCol2 { get; set; }

    public DateTime? DateCol1 { get; set; }
}
