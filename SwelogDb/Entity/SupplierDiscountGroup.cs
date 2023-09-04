using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierDiscountGroup
{
    public string SupplierDiscountGroupCode { get; set; } = null!;

    public string? SuppDiscGroupDesc { get; set; }

    public int? SuppDiscGroupDescTxtid { get; set; }

    public string? SuppDiscGroupDescFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<QtyDiscountStrucSupplier> QtyDiscountStrucSuppliers { get; } = new List<QtyDiscountStrucSupplier>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();

    public virtual ICollection<ValDiscountStrucSupplier> ValDiscountStrucSuppliers { get; } = new List<ValDiscountStrucSupplier>();
}
