using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StockTaking
{
    public int StockTakingNo { get; set; }

    public string PalletNo { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string WarehouseId { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public DateTime? StockListDate { get; set; }

    public decimal? ListDateBalance { get; set; }

    public DateTime? ReportDate { get; set; }

    public decimal? ReportDateBalance { get; set; }

    public decimal? PhysicalQuantity { get; set; }

    public decimal? DifferenceValue { get; set; }

    public string? ApprovalFlag { get; set; }

    public int? ParentStockTakingNo { get; set; }

    public string? StockTakingLevel { get; set; }

    public string? AuditStamp { get; set; }

    public string? StockTakingPrintFlag { get; set; }

    public string? PalletFlag { get; set; }

    public string? AlreadyPrintedFlag { get; set; }
}
