using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TableElement
{
    public int TableId { get; set; }

    public int TableElementNo { get; set; }

    public string? ElementType { get; set; }

    public string? AuditStamp { get; set; }
}
