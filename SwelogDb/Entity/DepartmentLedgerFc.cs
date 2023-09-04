using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DepartmentLedgerFc
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string DepartmentNo { get; set; } = null!;

    public decimal PeriodNo { get; set; }

    public string AccountNo { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public decimal? OpeningBalYear { get; set; }

    public decimal? OpeningBalPeriodFc { get; set; }

    public decimal? MovementPeriodFc { get; set; }

    public decimal? ClosingBalPeriodFc { get; set; }

    public string? DepartmentGroup { get; set; }

    public string? AccountTypeNo { get; set; }

    public string? AuditStamp { get; set; }
}
