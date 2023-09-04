using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CodeStringHdr
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string CountryGroupCode { get; set; } = null!;

    public string CustomerAccountCode { get; set; } = null!;

    public string? AccRecAccount { get; set; }

    public string? AcontoAccount { get; set; }

    public string? DiscountAccount { get; set; }

    public string? FreightAccount { get; set; }

    public string? PackagingAccount { get; set; }

    public string? PostalAccount { get; set; }

    public string? AdmChargeAccount { get; set; }

    public string? RoundingAccount { get; set; }

    public string? VatAccount { get; set; }

    public string? AuditStamp { get; set; }

    public string? DepartmentNo { get; set; }

    public virtual ICollection<CodeStringDtl> CodeStringDtls { get; } = new List<CodeStringDtl>();
}
