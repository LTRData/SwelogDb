using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ApCodeString
{
    public string CompanyNo { get; set; } = null!;

    public decimal RecordNo { get; set; }

    public string? Code { get; set; }

    public string? PayMode { get; set; }

    public string? Lkk { get; set; }

    public decimal? YearNo { get; set; }

    public string? AccPayAccount { get; set; }

    public string? GoodsAccount { get; set; }

    public string? VatAccount { get; set; }

    public string? PrelCostAccount { get; set; }

    public string? PayModeAccount { get; set; }

    public string? BadDebtAccount { get; set; }

    public string? DiscountAccount { get; set; }

    public string? RateDiffAccountGain { get; set; }

    public string? RateDiffAccountLoss { get; set; }

    public string? BankCostAccount { get; set; }

    public string? AdvToCreditorsAccount { get; set; }

    public string? AuditStamp { get; set; }

    public string? IntCostAccount { get; set; }

    public string? ProductGroupCode { get; set; }

    public string? ProductAccountCode { get; set; }
}
