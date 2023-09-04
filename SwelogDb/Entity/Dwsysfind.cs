using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Dwsysfind
{
    public string Dwname { get; set; } = null!;

    public string Columnname { get; set; } = null!;

    public string? Tablename { get; set; }

    public string? Fieldnames { get; set; }

    public string? SearchDwname { get; set; }

    public string? AuditStamp { get; set; }
}
