using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ProjectCheckList
{
    public string ProjectNumber { get; set; } = null!;

    public string ProjectType { get; set; } = null!;

    public int CheckId { get; set; }

    public string? CheckPointStatus { get; set; }
}
