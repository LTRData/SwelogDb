using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProductFamilyDtl
{
    public string ProductFamilyCode { get; set; } = null!;

    public short SequenceNumber { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? ContributionPercent { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ProductFamilyHdr ProductFamilyCodeNavigation { get; set; } = null!;
}
