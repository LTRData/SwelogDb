using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemSupplier
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

    public int? DaysForStatus1ToEdi { get; set; }

    public int? DaysForStatus3ToEdi { get; set; }

    public virtual Item ItemNumberNavigation { get; set; } = null!;

    public virtual ICollection<ItemSupplierItem> ItemSupplierItems { get; } = new List<ItemSupplierItem>();

    public virtual ICollection<ItemSupplierOpr> ItemSupplierOprs { get; } = new List<ItemSupplierOpr>();

    public virtual Supplier Supplier { get; set; } = null!;
}
