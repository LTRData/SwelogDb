using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VariantGroupDtl
{
    public string VariantGroup { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public decimal? OperationTime { get; set; }

    public decimal? SetupTime { get; set; }
}
