using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VariantProductGroupHdr
{
    public string VariantProductGroup { get; set; } = null!;

    public string? Description { get; set; }
}
