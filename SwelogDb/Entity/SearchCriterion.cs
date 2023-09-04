using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SearchCriterion
{
    public string SearchClassCode { get; set; } = null!;

    public string SearchCriteriaCode { get; set; } = null!;

    public int? CriteriaType { get; set; }

    public string? AuditStamp { get; set; }

    public int? SortOrder { get; set; }

    public virtual SearchClass SearchClassCodeNavigation { get; set; } = null!;

    public virtual ICollection<SearchCriteriaValue> SearchCriteriaValues { get; } = new List<SearchCriteriaValue>();
}
