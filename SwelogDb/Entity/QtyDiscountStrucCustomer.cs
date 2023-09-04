using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class QtyDiscountStrucCustomer
{
    public string ItemDiscountGroupCode { get; set; } = null!;

    public string CustomerDiscountGroupCode { get; set; } = null!;

    public int QuantityLowerLimit { get; set; }

    public string UnitMeasureCode { get; set; } = null!;

    public decimal? CustQtyDiscountPercent { get; set; }

    public string? AuditStamp { get; set; }

    public virtual CustomerDiscountGroup CustomerDiscountGroupCodeNavigation { get; set; } = null!;

    public virtual ItemDiscountGroup ItemDiscountGroupCodeNavigation { get; set; } = null!;

    public virtual UnitOfMeasure UnitMeasureCodeNavigation { get; set; } = null!;
}
