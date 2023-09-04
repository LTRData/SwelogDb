using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvAttestHdr
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string AccountNo { get; set; } = null!;

    public string DepartmentNo { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual ICollection<SuppInvAttestDtl> SuppInvAttestDtls { get; } = new List<SuppInvAttestDtl>();
}
