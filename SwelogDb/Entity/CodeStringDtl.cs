using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CodeStringDtl
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string CountryGroupCode { get; set; } = null!;

    public string CustomerAccountCode { get; set; } = null!;

    public string ProductGroupCode { get; set; } = null!;

    public string ProductAccountCode { get; set; } = null!;

    public string? GoodsAccount { get; set; }

    public string? ExpenseAccount { get; set; }

    public string? SalesAccount { get; set; }

    public string? AuditStamp { get; set; }

    public string TransType { get; set; } = null!;

    public string? DepartmentNo { get; set; }

    public string? DiscountAccount1 { get; set; }

    public string? DiscountAccount2 { get; set; }

    public virtual CodeStringHdr CodeStringHdr { get; set; } = null!;
}
