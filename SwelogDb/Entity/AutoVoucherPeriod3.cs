using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AutoVoucherPeriod3
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public decimal RecNo { get; set; }

    public decimal PeriodNo { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? Amount { get; set; }

    public string? AutoVoucherGenerated { get; set; }

    public string? AuditStamp { get; set; }

    public virtual AutoVoucherHead3 AutoVoucherHead3 { get; set; } = null!;
}
