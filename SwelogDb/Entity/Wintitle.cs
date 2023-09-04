using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Wintitle
{
    public string Classname { get; set; } = null!;

    public string Language { get; set; } = null!;

    public string? Title { get; set; }

    public string? AuditStamp { get; set; }
}
