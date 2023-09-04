using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeItemSupplier
{
    public string ItemNumber { get; set; } = null!;

    public string SupplierId { get; set; } = null!;

    public string? SupplierClassCode { get; set; }

    public decimal? SupplierGrade { get; set; }

    public string? AuditStamp { get; set; }

    public short? DeliveryTimeInDays { get; set; }

    public short? TransportTimeInDays { get; set; }

    public short? EarlyDeliveryTolerance { get; set; }

    public short? LateDeliveryTolerance { get; set; }

    public decimal? RecalculateFactor { get; set; }

    public decimal? QtyToleranceAllowed { get; set; }

    public virtual ICollection<ChangeItemSupplierItem> ChangeItemSupplierItems { get; } = new List<ChangeItemSupplierItem>();

    public virtual ICollection<ChangeItemSupplierOpr> ChangeItemSupplierOprs { get; } = new List<ChangeItemSupplierOpr>();

    public virtual Supplier Supplier { get; set; } = null!;
}
