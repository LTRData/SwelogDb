using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VariantGroupHdr
{
    public string VariantGroup { get; set; } = null!;

    public string? Description { get; set; }

    public string? Mandatory { get; set; }
}
