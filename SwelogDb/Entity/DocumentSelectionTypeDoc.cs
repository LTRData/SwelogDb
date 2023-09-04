using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentSelectionTypeDoc
{
    public string DocumentSelectionType { get; set; } = null!;

    public string DocType { get; set; } = null!;

    public string? AuditStamp { get; set; }

    public int? IndexInOrder { get; set; }
}
