using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProdpropValue
{
    public string ProductPropertySet { get; set; } = null!;

    public string ProductProperty { get; set; } = null!;

    public string ProductPropertyValues { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
