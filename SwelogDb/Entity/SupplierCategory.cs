using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierCategory
{
    public string SupplierCategoryCode { get; set; } = null!;

    public string? SupplierCategoryDesc { get; set; }

    public string? AuditStamp { get; set; }

    public string? CategoryType { get; set; }

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();
}
