using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwStockHistory
{
    public string ItemNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string TransactionCode { get; set; } = null!;

    public int TranSerial { get; set; }

    public decimal? TransactionQty { get; set; }

    public string? Warehouse { get; set; }

    public string? Location { get; set; }

    public decimal? BalanceQuantity { get; set; }

    public string? RefTranNo { get; set; }

    public string? RefTranId { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? TransactionValue { get; set; }

    public decimal? CostPrice { get; set; }

    public string? StockingUnit { get; set; }

    public string? PriceUnit { get; set; }

    public string? ItemDescription { get; set; }

    public string? StockPosition { get; set; }

    public decimal? PositionBalance { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string ItemNumber { get; set; } = null!;

    public string? PalletNo { get; set; }

    public string? ControlId { get; set; }

    public string? VinNumber { get; set; }
}
