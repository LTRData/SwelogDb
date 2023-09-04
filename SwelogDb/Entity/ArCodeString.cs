using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArCodeString
{
    public string CompanyNo { get; set; } = null!;

    public decimal RecordNo { get; set; }

    public string? Code { get; set; }

    public string? PayMode { get; set; }

    public string? Kbk { get; set; }

    public decimal? YearNo { get; set; }

    public string? AccRecAccount { get; set; }

    public string? GoodsAccount { get; set; }

    public string? VatAccount { get; set; }

    public string? PayModeAccount { get; set; }

    public string? BadDebtAccount { get; set; }

    public string? DiscountAccount { get; set; }

    public string? RateDiffAccountGain { get; set; }

    public string? RateDiffAccountLoss { get; set; }

    public string? IntAccount { get; set; }

    public string? AdmChargeAccount { get; set; }

    public string? AdvToDebtorsAccount { get; set; }

    public string? AuditStamp { get; set; }

    public string? DebitDiffAccount { get; set; }

    public string? CreditDiffAccount { get; set; }

    public string? RoundingAccount { get; set; }
}
