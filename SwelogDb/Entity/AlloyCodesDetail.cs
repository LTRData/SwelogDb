using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AlloyCodesDetail
{
    public string AlloyCode { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public decimal? AlloyPrice { get; set; }

    public string? CurrencyCode { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? AveragePrice { get; set; }
}
