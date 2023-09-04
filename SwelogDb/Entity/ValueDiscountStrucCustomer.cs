using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ValueDiscountStrucCustomer
{
    public string ItemDiscountGroupCode { get; set; } = null!;

    public string CustomerDiscountGroupCode { get; set; } = null!;

    public int ValueLowerLimit { get; set; }

    public decimal? CustValueDiscountPercent { get; set; }

    public string? AuditStamp { get; set; }

    public virtual CustomerDiscountGroup CustomerDiscountGroupCodeNavigation { get; set; } = null!;

    public virtual ItemDiscountGroup ItemDiscountGroupCodeNavigation { get; set; } = null!;
}
