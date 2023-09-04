using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Model
{
    public string ModelCode { get; set; } = null!;

    public string? ModelDescription { get; set; }

    public int? SortOrder { get; set; }

    public string? AuditStamp { get; set; }
}
