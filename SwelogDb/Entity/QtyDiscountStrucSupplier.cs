using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class QtyDiscountStrucSupplier
{
    public string ItemDiscountGroupCode { get; set; } = null!;

    public string SupplierDiscountGroupCode { get; set; } = null!;

    public int QuantityLowerLimit { get; set; }

    public string UnitMeasureCode { get; set; } = null!;

    public decimal? SuppQtyDiscountPercent { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ItemDiscountGroup ItemDiscountGroupCodeNavigation { get; set; } = null!;

    public virtual SupplierDiscountGroup SupplierDiscountGroupCodeNavigation { get; set; } = null!;

    public virtual UnitOfMeasure UnitMeasureCodeNavigation { get; set; } = null!;
}
