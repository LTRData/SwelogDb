using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ManufacturerItem
{
    public string ItemNumber { get; set; } = null!;

    public string ManufacturerId { get; set; } = null!;

    public string? ManufacturerItemNumber { get; set; }

    public string? ManufacturerItemDescription { get; set; }

    public int? ManufacturerItemTxtid { get; set; }

    public string? ManufacturerItemFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Manufacturer Manufacturer { get; set; } = null!;
}
