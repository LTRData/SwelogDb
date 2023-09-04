using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeItemSearch
{
    public string ItemNumber { get; set; } = null!;

    public string ItemSearchCode { get; set; } = null!;

    public string? SearchTermI { get; set; }

    public string? SearchTermIi { get; set; }

    public string? SearchTermIii { get; set; }

    public string? AuditStamp { get; set; }
}
