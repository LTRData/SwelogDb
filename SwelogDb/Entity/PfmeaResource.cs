using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PfmeaResource
{
    public int IdPfmeaResource { get; set; }

    public int PfmeaId { get; set; }

    public int VersionNumber { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
