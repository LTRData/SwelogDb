using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SavedCriterion
{
    public string Userid { get; set; } = null!;

    public string Classname { get; set; } = null!;

    public string? CriteriaDescription { get; set; }

    public string? Criteria { get; set; }

    public string? AuditStamp { get; set; }
}
