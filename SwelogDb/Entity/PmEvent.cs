using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PmEvent
{
    public int IdPmEvent { get; set; }

    public string? EventDescription { get; set; }

    public DateTime? EventDate { get; set; }

    public string? EventStatus { get; set; }

    public string? AuditStamp { get; set; }
}
