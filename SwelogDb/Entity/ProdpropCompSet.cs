using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProdpropCompSet
{
    public string ProductPropertySet { get; set; } = null!;

    public string ProductProperty { get; set; } = null!;

    public string ComponentGroup { get; set; } = null!;

    public int? ColIx { get; set; }

    public string? AuditStamp { get; set; }
}
