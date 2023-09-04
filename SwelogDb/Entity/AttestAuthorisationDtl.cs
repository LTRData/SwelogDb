using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AttestAuthorisationDtl
{
    public string Name { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public string AttestArea { get; set; } = null!;

    public string? IndividDevInd { get; set; }

    public string? InoutInd { get; set; }

    public string? AttestInd { get; set; }

    public string? AuditStamp { get; set; }

    public string? ProdAttestInd { get; set; }
}
