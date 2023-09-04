using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class LedgerWithClosingSb104033
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public decimal RecNo { get; set; }

    public decimal LineNo { get; set; }

    public string? Description { get; set; }

    public decimal? AmountFc { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Quantity { get; set; }

    public decimal JournalType { get; set; }

    public string? Series { get; set; }

    public decimal? VoucherNo { get; set; }

    public DateTime? VoucherDate { get; set; }

    public decimal? PeriodNo { get; set; }

    public string? AccountNo { get; set; }

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? UnitOfMeasure { get; set; }

    public string? FunctionNo { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string? CurrencyCode { get; set; }

    public string? Reconciled { get; set; }

    public string? AddDel { get; set; }

    public string? ClosingEntry { get; set; }

    public string? DepartmentGroup { get; set; }

    public string? ProductGroup { get; set; }

    public string? FunctionGroup { get; set; }

    public int? RecNoLineNo { get; set; }

    public string? Text2 { get; set; }
}
