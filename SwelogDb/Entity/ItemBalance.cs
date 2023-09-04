using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemBalance
{
    public string ItemNumber { get; set; } = null!;

    public string? DrawingNo { get; set; }

    public string? RevisionNo { get; set; }

    public string WarehouseId { get; set; } = null!;

    public string StockLocation { get; set; } = null!;

    public int LotNumber { get; set; }

    public string PalletNumber { get; set; } = null!;

    public string? OrderNumber { get; set; }

    public DateTime? ItemExpiryDate { get; set; }

    public string? ItemBalanceStatus { get; set; }

    public string? ControlId { get; set; }

    public decimal? TotalQuantity { get; set; }

    public decimal? QuantityUsed { get; set; }

    public decimal? QuantityReserved { get; set; }

    public DateTime? LastChangedDate { get; set; }

    public decimal? CapitalCost { get; set; }

    public decimal? FollowUpCost { get; set; }

    public string? CurrentLocation { get; set; }

    public DateTime? ExpectedReturnDate { get; set; }

    public string? AuditStamp { get; set; }
}
