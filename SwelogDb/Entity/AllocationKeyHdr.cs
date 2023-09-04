using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AllocationKeyHdr
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string AllocationKeyNo { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual ICollection<AllocationKeyDtl> AllocationKeyDtls { get; } = new List<AllocationKeyDtl>();

    public virtual Company CompanyNoNavigation { get; set; } = null!;
}
