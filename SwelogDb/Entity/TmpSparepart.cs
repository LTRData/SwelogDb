using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpSparepart
{
    public int RecId { get; set; }

    public string? MfgOrderType { get; set; }

    public int? YearNo { get; set; }

    public int? MonthNo { get; set; }

    public string? ProductGroupForToolNumber { get; set; }

    public string? SparepartNumber { get; set; }

    public string? SparepartDescription { get; set; }

    public string? ToolNumber { get; set; }

    public string? ToolNumberDescription { get; set; }

    public int? CostForSpareparts { get; set; }

    public string? AuditStamp { get; set; }
}
