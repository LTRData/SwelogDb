using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvAttestDtl
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string AccountNo { get; set; } = null!;

    public string DepartmentNo { get; set; } = null!;

    public string Purchaser { get; set; } = null!;

    public string Preattest1 { get; set; } = null!;

    public string Preattest2 { get; set; } = null!;

    public string FinalAttest { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual SuppInvAttestHdr SuppInvAttestHdr { get; set; } = null!;
}
