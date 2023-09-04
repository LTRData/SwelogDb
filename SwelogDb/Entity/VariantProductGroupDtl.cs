using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VariantProductGroupDtl
{
    public string VariantProductGroup { get; set; } = null!;

    public string VariantGroup { get; set; } = null!;

    public int? OperationNumber { get; set; }
}
