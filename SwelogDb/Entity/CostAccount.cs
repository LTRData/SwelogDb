using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CostAccount
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string AccountNo { get; set; } = null!;

    public string? DepartmentAccounting { get; set; }

    public string? ProductAccounting { get; set; }

    public string? ProjectAccounting { get; set; }

    public string? FunctionAccounting { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual FinancialYear FinancialYear { get; set; } = null!;
}
