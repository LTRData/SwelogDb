using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StockDetail
{
    public string ItemNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string TransactionCode { get; set; } = null!;

    public int TranSerial { get; set; }

    public string PalletNo { get; set; } = null!;

    public DateTime? RegDate { get; set; }

    public string? Warehouse { get; set; }

    public string? Location { get; set; }

    public string? OwnerType { get; set; }

    public string? Owner { get; set; }

    public int? LotNo { get; set; }

    public string? OrderNo { get; set; }

    public string? Item { get; set; }

    public decimal? Price { get; set; }

    public string? Status { get; set; }

    public string? ControlId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? QuantityIssued { get; set; }

    public DateTime? LastChangedDate { get; set; }

    public string? ItemRevNo { get; set; }

    public string? DrawingNo { get; set; }

    public string? DrawingRevNo { get; set; }

    public decimal? PalletCapitalCost { get; set; }

    public decimal? PalletReworkCost { get; set; }

    public decimal? QtyReserved { get; set; }

    public string? CurrentLocation { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? RejectedQty { get; set; }

    public decimal? TransactionQty { get; set; }

    public decimal? TransactionValue { get; set; }

    public string? VinNumber { get; set; }

    public decimal? Breadth { get; set; }

    public string? EcnNumber { get; set; }
}
