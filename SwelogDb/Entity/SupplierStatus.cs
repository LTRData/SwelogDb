using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierStatus
{
    public string SupplierStatusCode { get; set; } = null!;

    public string? SupplierStatusDescription { get; set; }

    public int? SupplierStatusTxtid { get; set; }

    public string? SupplierStatusFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();
}
