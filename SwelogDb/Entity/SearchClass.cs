using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SearchClass
{
    public string SearchClassCode { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual ICollection<SearchCriterion> SearchCriteria { get; } = new List<SearchCriterion>();
}
