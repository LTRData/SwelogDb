using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SearchItemValue
{
    public string ItemNumber { get; set; } = null!;

    public string SearchClassCode { get; set; } = null!;

    public string SearchCriteriaCode { get; set; } = null!;

    public string? SearchCriteriaValueCode { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Item ItemNumberNavigation { get; set; } = null!;
}
