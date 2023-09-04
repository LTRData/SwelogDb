using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Priority
{
    public string PriorityId { get; set; } = null!;

    public string? PriorityDescription { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<DefectReport> DefectReports { get; } = new List<DefectReport>();
}
