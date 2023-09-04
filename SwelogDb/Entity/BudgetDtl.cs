﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BudgetDtl
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string BudgetType { get; set; } = null!;

    public string BudgetNo { get; set; } = null!;

    public decimal LineNo { get; set; }

    public string AccountNo { get; set; } = null!;

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string? UnitOfMeasure { get; set; }

    public decimal? Quantity { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? AmountFc { get; set; }

    public decimal? AmountBc { get; set; }

    public string? AllocationKeyNo { get; set; }

    public string? AuditStamp { get; set; }

    public virtual A? A { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual B? B { get; set; }

    public virtual ICollection<BudgetAmt> BudgetAmts { get; } = new List<BudgetAmt>();

    public virtual BudgetHdr BudgetHdr { get; set; } = null!;

    public virtual C? C { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual D? D { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Function? Function { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Project? Project { get; set; }

    public virtual UnitOfMeasure? UnitOfMeasureNavigation { get; set; }
}