using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InternetLink
{
    public int LinkId { get; set; }

    public string? LinkDescription { get; set; }

    public string? LinkAddress { get; set; }

    public string? AuditStamp { get; set; }
}
