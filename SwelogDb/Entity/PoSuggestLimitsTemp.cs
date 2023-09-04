using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PoSuggestLimitsTemp
{
    public int ProcessId { get; set; }

    public string? ParentItemNumber { get; set; }

    public decimal? ParentQuantity { get; set; }

    public string? ParentItemType1 { get; set; }

    public string? ComponentItemNumber { get; set; }

    public decimal? ComponentQuantity { get; set; }

    public string? ComponentItemType1 { get; set; }
}
