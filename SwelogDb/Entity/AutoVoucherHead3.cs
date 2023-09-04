using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AutoVoucherHead3
{
    public string CompanyNo { get; set; } = null!;

    public decimal RecNo { get; set; }

    public string AutoVoucherId { get; set; } = null!;

    public decimal? Amount { get; set; }

    public DateTime? StartDate { get; set; }

    public decimal? NoOfPeriods { get; set; }

    public string? Text { get; set; }

    public string? AuditStamp { get; set; }

    public string? PercentAmountFlag { get; set; }

    public virtual ICollection<AutoVoucherDetail3> AutoVoucherDetail3s { get; } = new List<AutoVoucherDetail3>();

    public virtual ICollection<AutoVoucherPeriod3> AutoVoucherPeriod3s { get; } = new List<AutoVoucherPeriod3>();

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
