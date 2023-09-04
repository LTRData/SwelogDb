using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ColumnTemplate
{
    public short ColTempNo { get; set; }

    public int ColTempRecNo { get; set; }

    public string? Syntax { get; set; }

    public string? AuditStamp { get; set; }

    public string? Description { get; set; }
}
