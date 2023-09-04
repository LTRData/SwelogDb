using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwOfferStrComp
{
    public string ItemNumber { get; set; } = null!;

    public string ParentPart { get; set; } = null!;

    public string ComponentPart { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public string? ItemType1 { get; set; }

    public string PositionIndicator { get; set; } = null!;

    public short OperationNumber { get; set; }
}
