using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TempScrapComponent
{
    public int? ProcessId { get; set; }

    public string? ParentPart { get; set; }

    public decimal? QuantityOfParent { get; set; }

    public string? ComponentPart { get; set; }

    public decimal? QuantityOfComponent { get; set; }

    public decimal? OfferQuantity { get; set; }
}
