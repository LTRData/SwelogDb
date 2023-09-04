using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class RoundingHdr
{
    public string CurrencyCode { get; set; } = null!;

    public string RoundingPurposeCode { get; set; } = null!;

    public string? PurposeDescription { get; set; }

    public short? RoundingFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual CurrencyTable CurrencyCodeNavigation { get; set; } = null!;

    public virtual ICollection<RoundingDtl> RoundingDtls { get; } = new List<RoundingDtl>();
}
