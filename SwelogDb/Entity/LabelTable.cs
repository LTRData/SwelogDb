using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class LabelTable
{
    public string LanguageCode { get; set; } = null!;

    public int LabelCode { get; set; }

    public string? LabelDescription { get; set; }

    public string? AuditStamp { get; set; }
}
