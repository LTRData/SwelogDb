using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpFreightDataFromXmlBring
{
    public string DelnoteNo { get; set; } = null!;

    public decimal? AmountFc { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CurrFormat { get; set; }

    public string? ServiceCode { get; set; }

    public string? SelectFlag { get; set; }

    public short? YearNo { get; set; }

    public string? InvoiceSeries { get; set; }

    public int? InvoiceNo { get; set; }
}
