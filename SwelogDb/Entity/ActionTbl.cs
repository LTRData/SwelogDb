using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActionTbl
{
    public string ActionId { get; set; } = null!;

    public string ActionDescription { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public virtual ICollection<DefectReport> DefectReports { get; } = new List<DefectReport>();
}
