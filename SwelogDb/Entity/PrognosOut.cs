using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PrognosOut
{
    public int RecNo { get; set; }

    public string? SuppliersPartNumber { get; set; }

    public string? PartNumber { get; set; }

    public string? DeliveryDate { get; set; }

    public int? Quantity { get; set; }
}
