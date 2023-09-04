using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemStore
{
    public string WarehouseId { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public string ItemNo { get; set; } = null!;

    public string? ItemRevisionNo { get; set; }

    public string? DrawingNo { get; set; }

    public string? DrawingRevNo { get; set; }

    public string? AuditStamp { get; set; }
}
