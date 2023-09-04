using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BudgetRateHistory
{
    public int SerialNumber { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? DateOfRate { get; set; }

    public decimal? BudgetRate { get; set; }
}
