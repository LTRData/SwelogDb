using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Prodprop
{
    public string ProductPropertySet { get; set; } = null!;

    public string ProductProperty { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual ProdpropSet ProductPropertySetNavigation { get; set; } = null!;
}
