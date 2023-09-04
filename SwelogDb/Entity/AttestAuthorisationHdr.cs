using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AttestAuthorisationHdr
{
    public string Name { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public int? AttestLevel { get; set; }

    public string? AuditStamp { get; set; }
}
