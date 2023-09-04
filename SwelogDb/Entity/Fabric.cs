using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Fabric
{
    public string FabricCode { get; set; } = null!;

    public string? FabricDescription { get; set; }

    public string? AuditStamp { get; set; }
}
