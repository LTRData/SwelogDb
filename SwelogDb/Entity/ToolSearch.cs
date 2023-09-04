using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolSearch
{
    public string ToolNumber { get; set; } = null!;

    public string SearchCode { get; set; } = null!;

    public string? SearchTermI { get; set; }

    public string? SearchTermIi { get; set; }

    public string? SearchTermIii { get; set; }

    public string? AuditStamp { get; set; }
}
