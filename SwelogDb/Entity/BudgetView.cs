using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BudgetView
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string BudgetType { get; set; } = null!;

    public string BudgetNo { get; set; } = null!;

    public string? ProjectNoHdr { get; set; }

    public string? Description { get; set; }

    public decimal? BudgetGroup { get; set; }

    public string? IncludeInResultanalys { get; set; }

    public decimal LineNo { get; set; }

    public string AccountNo { get; set; } = null!;

    public string? DepartmentNo { get; set; }

    public string? DeptNo { get; set; }

    public string? DepartmentGroup { get; set; }

    public string? ProductNo { get; set; }

    public string? ProdNo { get; set; }

    public string? ProductGroup { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? FuncNo { get; set; }

    public string? FunctionGroup { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string? UnitOfMeasure { get; set; }

    public decimal? Quantity { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? AmountFcDtl { get; set; }

    public decimal? AmountBcDtl { get; set; }

    public string? AllocationKeyNo { get; set; }

    public decimal PeriodNo { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? AmountFc { get; set; }

    public decimal? AmountBc { get; set; }

    public decimal? Dummy { get; set; }
}
