using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PicklistDetail
{
    public string PicklistNumber { get; set; } = null!;

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public string DeliveryAddressId { get; set; } = null!;

    public decimal? DesiredQuantity { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? WarehouseId { get; set; }

    public string? StockLocation { get; set; }

    public string? AuditStamp { get; set; }

    public string? ParentItem { get; set; }

    public decimal? ParentQuantity { get; set; }

    public string? ParentStockLocation { get; set; }

    public decimal? ParentDeliveredQuantity { get; set; }

    public string? NewLine { get; set; }

    public string? CustomerId { get; set; }

    public string? DeliveryNote { get; set; }

    public string? Status { get; set; }

    public short? LineNo { get; set; }

    public virtual PicklistHeader PicklistNumberNavigation { get; set; } = null!;

    public virtual Warehouse? Warehouse { get; set; }
}
