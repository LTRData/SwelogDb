using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderTotalDiscountDtl
{
    public string DiscountTermCode { get; set; } = null!;

    public decimal DiscountLimitingValue { get; set; }

    public decimal? OrderTotalDiscPercentile { get; set; }

    public string? AuditStamp { get; set; }

    public virtual OrderTotalDiscountHdr DiscountTermCodeNavigation { get; set; } = null!;
}
