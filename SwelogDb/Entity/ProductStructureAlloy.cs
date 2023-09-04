using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductStructureAlloy
{
    public int SerialNumber { get; set; }

    public string? ParentPart { get; set; }

    public string? ComponentPart { get; set; }

    public decimal? ParentQuantity { get; set; }

    public string? ParentUom { get; set; }

    public decimal? ComponentQuantity { get; set; }

    public string? ComponentUom { get; set; }

    public decimal? OfferQuantity { get; set; }
}
