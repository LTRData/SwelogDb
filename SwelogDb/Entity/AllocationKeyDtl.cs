using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AllocationKeyDtl
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string AllocationKeyNo { get; set; } = null!;

    public decimal PeriodNo { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? Percentage { get; set; }

    public string? AuditStamp { get; set; }

    public virtual AllocationKeyHdr AllocationKeyHdr { get; set; } = null!;

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
