using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AutoVoucherDetail1
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public decimal RecNo { get; set; }

    public decimal LineNo { get; set; }

    public string AmountSign { get; set; } = null!;

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

    public string? AuditStamp { get; set; }

    public string? UpdateAllCodingKeys { get; set; }

    public string? VatCode { get; set; }

    public virtual Account? Account { get; set; }

    public virtual AutoVoucherHead1 AutoVoucherHead1 { get; set; } = null!;
}
