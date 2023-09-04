using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class FinancialPeriodLeasing
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public decimal PeriodNo { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
