using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletDeviation
{
    public string PalletNo { get; set; } = null!;

    public DateTime? RegDate { get; set; }

    public string? Warehouse { get; set; }

    public string? Location { get; set; }

    public string? OwnerType { get; set; }

    public string? Owner { get; set; }

    public string? LotNo { get; set; }

    public string? OrderNo { get; set; }

    public decimal? Price { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? Item { get; set; }

    public string? Status { get; set; }

    public string? ControlId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? QuantityIssued { get; set; }

    public DateTime? LastChangedDt { get; set; }

    public string? ItemRevNo { get; set; }

    public string? DrawingNo { get; set; }

    public string? DrawingRevNo { get; set; }

    public decimal? PalletCapitalCost { get; set; }

    public decimal? PalletReworkCost { get; set; }

    public decimal? QtyReserved { get; set; }

    public string? CurrLoc { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? RejectedQty { get; set; }

    public decimal? PalletCost { get; set; }

    public decimal? PalletCostIssued { get; set; }

    public int? OperationNumber { get; set; }

    public decimal? TotaccumComponentCost { get; set; }

    public decimal? TotaccumWagecost { get; set; }

    public decimal? TotaccumOther { get; set; }

    public decimal? TotaccumAlloyCost { get; set; }
}
