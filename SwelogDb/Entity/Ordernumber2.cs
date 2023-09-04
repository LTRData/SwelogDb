using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Ordernumber2
{
    public string OrderNumber21 { get; set; } = null!;

    public decimal? SumMfgorder { get; set; }

    public decimal? SumPurchase { get; set; }

    public decimal? SumStoredItems { get; set; }

    public decimal? SumInvoice { get; set; }

    public string UserId { get; set; } = null!;
}
