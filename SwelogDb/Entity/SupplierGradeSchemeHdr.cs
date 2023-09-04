using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierGradeSchemeHdr
{
    public string ClassId { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public string? AuditStamp { get; set; }
}
