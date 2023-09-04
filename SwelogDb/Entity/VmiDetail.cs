using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VmiDetail
{
    public string? OrderNumber { get; set; }

    public string? ItemNumber { get; set; }

    public DateTime? PromisedDate { get; set; }

    public decimal? PromisedQuantity { get; set; }

    public decimal? ItemPrice { get; set; }
}
