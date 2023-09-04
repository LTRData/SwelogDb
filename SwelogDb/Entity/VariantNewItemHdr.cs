using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VariantNewItemHdr
{
    public string ItemNumber { get; set; } = null!;

    public string? Description { get; set; }

    public string? VariantProductGroup { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public decimal? TotalOperationTime { get; set; }

    public decimal? TotalSetupTime { get; set; }

    public decimal? TotalSellingPrice { get; set; }

    public string? VariantText { get; set; }
}
