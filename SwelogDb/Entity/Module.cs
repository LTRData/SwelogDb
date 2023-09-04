using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Module
{
    public string ModuleId { get; set; } = null!;

    public string? ModuleDescription { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<DefectReport> DefectReports { get; } = new List<DefectReport>();
}
