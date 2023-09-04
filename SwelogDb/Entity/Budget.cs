using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Budget
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public decimal LineNo { get; set; }

    public decimal PeriodNo { get; set; }

    public string AccountNo { get; set; } = null!;

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public decimal? AmountBc { get; set; }

    public DateTime StartDate { get; set; }
}
