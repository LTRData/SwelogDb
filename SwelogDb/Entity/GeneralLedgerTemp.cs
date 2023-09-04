using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class GeneralLedgerTemp
{
    public string? AccountNo { get; set; }

    public decimal? PeriodNo { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AmountFc { get; set; }

    public decimal? Quantity { get; set; }

    public string? ClosingEntry { get; set; }

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string? CurrencyCode { get; set; }
}
