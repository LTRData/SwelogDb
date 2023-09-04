using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CLedger
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string CNo { get; set; } = null!;

    public decimal PeriodNo { get; set; }

    public string AccountNo { get; set; } = null!;

    public decimal? OpeningBalYear { get; set; }

    public decimal? OpeningBalPeriod { get; set; }

    public decimal? MovementPeriod { get; set; }

    public decimal? ClosingBalPeriod { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? MovementPrdForClsgEntry { get; set; }

    public decimal? ClosgBalPrdWithClsgEntry { get; set; }

    public decimal? QuantityWithClsgEntry { get; set; }

    public string? AccountTypeNo { get; set; }

    public string? AuditStamp { get; set; }
}
