using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InvoiceStatsView
{
    public string CompNo { get; set; } = null!;

    public DateTime? InvoiceDate { get; set; }

    public string? CustomerNo { get; set; }

    public string? CurrCode { get; set; }

    public string? SalesmanCode { get; set; }

    public string ProductGroup { get; set; } = null!;

    public decimal? HdrDisAmtFc { get; set; }

    public decimal? BaseUnit { get; set; }

    public decimal? LineAmtBc { get; set; }
}
