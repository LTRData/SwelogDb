using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PurchaseOprArrival
{
    public string GoodsentryNo { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public DateTime? ArrivalDate { get; set; }

    public string? WarehouseId { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public short? OperationNumber { get; set; }

    public decimal? ReceivedQuantity { get; set; }

    public decimal? SellingPrice { get; set; }

    public short? PriceUnit { get; set; }

    public string? SupplierId { get; set; }

    public string? DeliveryNoteNo { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? SetupCost { get; set; }
}
