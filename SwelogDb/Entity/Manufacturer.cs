using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Manufacturer
{
    public string ManufacturerId { get; set; } = null!;

    public string? ManufacturerName { get; set; }

    public int? ManufacturerNameTxtid { get; set; }

    public string? ManufacturerNameFlag { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ManufacturerItem> ManufacturerItems { get; } = new List<ManufacturerItem>();
}
