using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemSearch
{
    public string ItemNumber { get; set; } = null!;

    public string ItemSearchCode { get; set; } = null!;

    public string? SearchTermI { get; set; }

    public string? SearchTermIi { get; set; }

    public string? SearchTermIii { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Item ItemNumberNavigation { get; set; } = null!;
}
