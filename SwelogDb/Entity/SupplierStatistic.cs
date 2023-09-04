using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierStatistic
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string SupplierNo { get; set; } = null!;

    public decimal PeriodNo { get; set; }

    public decimal? AmtPurchased { get; set; }

    public decimal? IntAmt { get; set; }

    public decimal? VatAmt { get; set; }

    public decimal? DisAmtUsed { get; set; }

    public decimal? DisAmtNotUsed { get; set; }

    public decimal? RateDiffAmt { get; set; }

    public short? NoOfInvoices { get; set; }

    public short? NoOfPaidInvoices { get; set; }

    public short? NoOfDueDays { get; set; }

    public short? NoOfPayDays { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual FinancialYear FinancialYear { get; set; } = null!;

    public virtual Supplier SupplierNoNavigation { get; set; } = null!;
}
