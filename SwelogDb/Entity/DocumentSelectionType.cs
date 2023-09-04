using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DocumentSelectionType
{
    public string DocumentSelectionType1 { get; set; } = null!;

    public string? DocumentSelectionTypeDesc { get; set; }

    public int? DocumentSelectionTypeDescTxtid { get; set; }

    public string? DocumentSelectionTypeDescFlag { get; set; }

    public string? AuditStamp { get; set; }
}
