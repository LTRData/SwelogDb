using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VariantNewItemDtl
{
    public string ItemNumber { get; set; } = null!;

    public string ComponentPart { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public decimal? OperationTime { get; set; }

    public decimal? SetupTime { get; set; }

    public int OperationNumber { get; set; }

    public decimal? SellingPrice { get; set; }

    public short? PriceUnitNum { get; set; }
}
