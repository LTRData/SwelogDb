using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class FabricColour
{
    public string FabricCode { get; set; } = null!;

    public string ColourCode { get; set; } = null!;

    public string? ColourDescription { get; set; }

    public string? AuditStamp { get; set; }
}
