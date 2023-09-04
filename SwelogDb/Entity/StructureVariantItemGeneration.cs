using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StructureVariantItemGeneration
{
    public string GenerationCode { get; set; } = null!;

    public string Item { get; set; } = null!;

    public int? AppearenceIx { get; set; }
}
