using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemSupplierText
{
    public string ItemNumber { get; set; } = null!;

    public string SupplierId { get; set; } = null!;

    public string TextCode { get; set; } = null!;

    public short SequenceNumber { get; set; }

    public int? InternalExternalTxtid { get; set; }

    public string? InternalExternalFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Item ItemNumberNavigation { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
