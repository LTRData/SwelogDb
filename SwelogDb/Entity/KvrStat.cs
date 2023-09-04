using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class KvrStat
{
    public string CustomerId { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string? EuCountryCode { get; set; }

    public string? VatRegistrationNumber { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? OriginalRate { get; set; }

    public decimal? NetInvAmtBc { get; set; }
}
