using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Program
{
    public string ProgramId { get; set; } = null!;

    public string? ProgramDescription { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<DefectReport> DefectReports { get; } = new List<DefectReport>();
}
