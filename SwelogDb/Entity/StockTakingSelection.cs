using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StockTakingSelection
{
    public int StockTakingNo { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? ValueFrom { get; set; }

    public string? ValueTo { get; set; }

    public string? SelectionMode { get; set; }

    public string? AuditStamp { get; set; }
}
