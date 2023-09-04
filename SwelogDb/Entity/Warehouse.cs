using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Warehouse
{
    public string WarehouseId { get; set; } = null!;

    public string? WarehouseDescription { get; set; }

    public int? WarehouseDescriptionTxtid { get; set; }

    public string? WarehouseDescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<CustomerOrderDtl> CustomerOrderDtls { get; } = new List<CustomerOrderDtl>();

    public virtual ICollection<PicklistDetail> PicklistDetails { get; } = new List<PicklistDetail>();

    public virtual ICollection<PurchaseOrderDtl> PurchaseOrderDtls { get; } = new List<PurchaseOrderDtl>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; } = new List<PurchaseOrderHeader>();

    public virtual ICollection<StoreLocation> StoreLocations { get; } = new List<StoreLocation>();
}
