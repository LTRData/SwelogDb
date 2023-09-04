using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StockValueArchive
{
    public int Id { get; set; }

    public string? RecordType { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryDesc { get; set; }

    public string? Status { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public string? StoreLocation { get; set; }

    public string? StockPosition { get; set; }

    public string? PalletNo { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Value { get; set; }

    public string? AuditStamp { get; set; }

    public int? YearMonth { get; set; }

    public decimal? AlloyValue { get; set; }
}
