using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TempTablePurchaseOrder
{
    public int SerialNumber { get; set; }

    public int ProcessId { get; set; }

    public string ItemNumber { get; set; } = null!;

    public DateTime? PlannedDeliveryDate { get; set; }

    public decimal? OrderQuantity { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? ProductNo { get; set; }

    public string? GoodsMarking { get; set; }

    public string? InternalGoodsReceiver { get; set; }

    public string? ProjectNumber { get; set; }

    public string? ModuleId { get; set; }

    public string? ItemDescription { get; set; }

    public decimal? PurchasePrice { get; set; }

    public string? OrderText { get; set; }
}
