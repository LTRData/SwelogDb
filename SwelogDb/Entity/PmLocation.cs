using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PmLocation
{
    public int IdPmLocation { get; set; }

    public string? LocationDescription { get; set; }

    public string? AuditStamp { get; set; }
}
