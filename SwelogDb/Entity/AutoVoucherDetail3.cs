using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AutoVoucherDetail3
{
    public string CompanyNo { get; set; } = null!;

    public decimal RecNo { get; set; }

    public decimal LineNo { get; set; }

    public string? AccountNo { get; set; }

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public decimal? Percentage { get; set; }

    public string? DebitCreditSign { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? Amount { get; set; }

    public string? VatCode { get; set; }

    public virtual A? A { get; set; }

    public virtual AutoVoucherHead3 AutoVoucherHead3 { get; set; } = null!;

    public virtual B? B { get; set; }

    public virtual C? C { get; set; }

    public virtual D? D { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Function? Function { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Project? Project { get; set; }
}
