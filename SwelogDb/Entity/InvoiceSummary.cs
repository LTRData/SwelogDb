using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InvoiceSummary
{
    public string CompanyNo { get; set; } = null!;

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public short SlNo { get; set; }

    public string? Columns { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? Base { get; set; }

    public decimal? Total { get; set; }

    public decimal? BaseDc { get; set; }

    public decimal? TotalDc { get; set; }
}
