using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Dwvariou
{
    public string Dwname { get; set; } = null!;

    public string? Dwsharename { get; set; }

    public string? AuditStamp { get; set; }
}
