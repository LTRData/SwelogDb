using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StockSummary
{
    public string ItemNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string TransactionCode { get; set; } = null!;

    public int TranSerial { get; set; }

    public decimal? TransactionQty { get; set; }

    public string? Warehouse { get; set; }

    public string? Location { get; set; }

    public string? ItemRevNo { get; set; }

    public string? DrawingNo { get; set; }

    public string? DrawingRevNo { get; set; }

    public decimal? BalanceQuantity { get; set; }

    public string? RefTranNo { get; set; }

    public string? RefTranId { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? TransactionValue { get; set; }

    public DateTime? EventDate { get; set; }

    public decimal? TransferJnlYearNo { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVoucherNo { get; set; }

    public string? StockPosition { get; set; }

    public decimal? PositionBalance { get; set; }

    public string? ReceivedNotInvoiced { get; set; }

    public string? ReceivedNotInvoicedProcessed { get; set; }

    public string? CustomerId { get; set; }

    public int IdStockSummary { get; set; }

    public string? OrderNumber { get; set; }

    public string? ProjectNumber { get; set; }

    public string? MainCustomer { get; set; }

    public string? SupplierId { get; set; }
}
