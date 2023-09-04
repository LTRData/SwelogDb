using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class StructureVariantNewItem
{
    public DateTime CreatedDatetime { get; set; }

    public short SerialNo { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public string? CustomerId { get; set; }

    public string? ProductVariantGroup { get; set; }
}
