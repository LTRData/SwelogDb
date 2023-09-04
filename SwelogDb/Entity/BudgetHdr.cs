using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BudgetHdr
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string BudgetType { get; set; } = null!;

    public string BudgetNo { get; set; } = null!;

    public string? ProjectNo { get; set; }

    public string? Description { get; set; }

    public decimal? BudgetGroup { get; set; }

    public string? AuditStamp { get; set; }

    public string? IncludeInResultanalys { get; set; }

    public virtual ICollection<BudgetDtl> BudgetDtls { get; } = new List<BudgetDtl>();

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual FinancialYear FinancialYear { get; set; } = null!;

    public virtual Project? Project { get; set; }
}
