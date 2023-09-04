using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TempTableFictiveItem
{
    public string? ParentId { get; set; }

    public string? ComponentPart { get; set; }

    public decimal? ContributoryQty { get; set; }

    public int? Textid { get; set; }

    public decimal? FixedUsage { get; set; }
}
