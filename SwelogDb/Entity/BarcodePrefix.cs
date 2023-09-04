using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BarcodePrefix
{
    public int ConfigId { get; set; }

    public string? CustomerItemId { get; set; }

    public string? SupplierItemId { get; set; }

    public string? SerialKeyId { get; set; }

    public string? PalletId { get; set; }

    public string? EanId { get; set; }

    public string? ItemId { get; set; }

    public string? LocationId { get; set; }

    public string? PositionId { get; set; }

    public string? AuditStamp { get; set; }
}
