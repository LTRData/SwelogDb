using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReferenceType
{
    public string ReferenceType1 { get; set; } = null!;

    public string? ReferenceDescription { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<CustomerReference> CustomerReferences { get; } = new List<CustomerReference>();

    public virtual ICollection<OurReference> OurReferences { get; } = new List<OurReference>();

    public virtual ICollection<SupplierReference> SupplierReferences { get; } = new List<SupplierReference>();
}
