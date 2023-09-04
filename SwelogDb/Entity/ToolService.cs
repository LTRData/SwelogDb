using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolService
{
    public string OrderNumber { get; set; } = null!;

    public string? ToolNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? OrderedBy { get; set; }

    public string? SupplierId { get; set; }

    public string? FreeText { get; set; }

    public string? AuditStamp { get; set; }
}
