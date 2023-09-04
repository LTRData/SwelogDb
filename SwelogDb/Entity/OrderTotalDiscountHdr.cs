using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OrderTotalDiscountHdr
{
    public string DiscountTermCode { get; set; } = null!;

    public string? DiscountTermDescription { get; set; }

    public string? CurrencyCode { get; set; }

    public string? AuditStamp { get; set; }

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual ICollection<OrderTotalDiscountDtl> OrderTotalDiscountDtls { get; } = new List<OrderTotalDiscountDtl>();
}
