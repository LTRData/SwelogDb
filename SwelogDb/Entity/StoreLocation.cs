using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StoreLocation
{
    public string WarehouseId { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public string? LocationDescription { get; set; }

    public string? StoreType { get; set; }

    public string? AuditStamp { get; set; }

    public string? CommissionCustomer { get; set; }

    public string? CompanyNo { get; set; }

    public string? DepartmentNo { get; set; }

    public string? PickingStore { get; set; }

    public string? StoreCategory { get; set; }

    public string? StoreOwnersCategory { get; set; }

    public string? StoreOwner { get; set; }

    public string? DeliveryStore { get; set; }

    public string? LocationType { get; set; }

    public virtual Customer? CommissionCustomerNavigation { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<StockPosition> StockPositions { get; } = new List<StockPosition>();

    public virtual Warehouse Warehouse { get; set; } = null!;
}
