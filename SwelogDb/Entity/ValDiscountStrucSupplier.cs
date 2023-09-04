using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ValDiscountStrucSupplier
{
    public string ItemDiscountGroupCode { get; set; } = null!;

    public string SupplierDiscountGroupCode { get; set; } = null!;

    public int ValueLowerLimit { get; set; }

    public decimal? SuppValDiscountPercent { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ItemDiscountGroup ItemDiscountGroupCodeNavigation { get; set; } = null!;

    public virtual SupplierDiscountGroup SupplierDiscountGroupCodeNavigation { get; set; } = null!;
}
