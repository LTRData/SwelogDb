using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class RoundingDtl
{
    public string CurrencyCode { get; set; } = null!;

    public string RoundingPurposeCode { get; set; } = null!;

    public decimal RoundingLimitingAmount { get; set; }

    public decimal? RoundingTo { get; set; }

    public string? AuditStamp { get; set; }

    public virtual RoundingHdr RoundingHdr { get; set; } = null!;
}
