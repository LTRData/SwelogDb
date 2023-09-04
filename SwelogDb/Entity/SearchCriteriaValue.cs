using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SearchCriteriaValue
{
    public string SearchClassCode { get; set; } = null!;

    public string SearchCriteriaCode { get; set; } = null!;

    public string SearchCriteriaValueCode { get; set; } = null!;

    public int? SerialNo { get; set; }

    public string? AuditStamp { get; set; }

    public virtual SearchCriterion SearchC { get; set; } = null!;
}
