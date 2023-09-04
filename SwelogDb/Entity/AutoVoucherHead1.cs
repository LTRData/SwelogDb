using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AutoVoucherHead1
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public decimal RecNo { get; set; }

    public string? AccountNo { get; set; }

    public string? DepartmentNo { get; set; }

    public string? ProductNo { get; set; }

    public string? ProjectNo { get; set; }

    public string? FunctionNo { get; set; }

    public string? ANo { get; set; }

    public string? BNo { get; set; }

    public string? CNo { get; set; }

    public string? DNo { get; set; }

    public string? AmountSign { get; set; }

    public string? AuditStamp { get; set; }

    public string? VatCode { get; set; }

    public virtual A? A { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<AutoVoucherDetail1> AutoVoucherDetail1s { get; } = new List<AutoVoucherDetail1>();

    public virtual B? B { get; set; }

    public virtual C? C { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual D? D { get; set; }

    public virtual Department? Department { get; set; }

    public virtual FinancialYear FinancialYear { get; set; } = null!;

    public virtual Function? Function { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Project? Project { get; set; }
}
