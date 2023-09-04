using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProdpropSet
{
    public string ProductPropertySet { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public string? NumberPrefix { get; set; }

    public int? LastNumber { get; set; }

    public int? NumberPositions { get; set; }

    public virtual ICollection<Prodprop> Prodprops { get; } = new List<Prodprop>();
}
