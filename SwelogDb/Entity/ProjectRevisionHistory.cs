using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProjectRevisionHistory
{
    public string ProjectItemNumber { get; set; } = null!;

    public string RevisionNo { get; set; } = null!;

    public string? Comments { get; set; }

    public DateTime? RevisionDate { get; set; }
}
