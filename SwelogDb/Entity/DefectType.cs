using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DefectType
{
    public string DefectTypeId { get; set; } = null!;

    public string? DefectDescription { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<DefectReport> DefectReports { get; } = new List<DefectReport>();
}
