using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ScrapCodesDetail
{
    public string ScrapCode { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public decimal? ScrapPrice { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? AveragePrice { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? BasicPrice { get; set; }
}
