using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Dwsysnew
{
    public string Dwname { get; set; } = null!;

    public string Columnname { get; set; } = null!;

    public string Windowname { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
