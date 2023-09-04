using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AttestArea
{
    public string AttestArea1 { get; set; } = null!;

    public string? AttestAreaDescr { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? AuditStamp { get; set; }

    public string? ProdAttestInd { get; set; }

    public string? SelfAttestYn { get; set; }
}
