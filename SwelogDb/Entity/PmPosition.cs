using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PmPosition
{
    public int IdPmPosition { get; set; }

    public string? PositionDescription { get; set; }

    public string? AuditStamp { get; set; }
}
