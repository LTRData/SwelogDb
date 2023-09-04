using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvView
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public string? CustomerNo { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CountryGroupCode { get; set; }

    public decimal? ItemLineAmtBcTot { get; set; }

    public decimal? AcontoLineAmtBcTot { get; set; }

    public decimal? ServiceLineAmtBcTot { get; set; }

    public decimal? DisAmtBc { get; set; }

    public decimal? RoundingAmtBc { get; set; }

    public decimal? NetInvAmtBc { get; set; }

    public decimal? VatAmtBc { get; set; }
}
