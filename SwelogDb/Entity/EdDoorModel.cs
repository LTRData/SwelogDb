using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EdDoorModel
{
    public string ModelNumber { get; set; } = null!;

    public string? ModelDescription { get; set; }

    public int? MinBreadth { get; set; }

    public string? NotAllowedClassCodes { get; set; }

    public string? AuditStamp { get; set; }

    public string? NotAllowedWoodTypes { get; set; }
}
