using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PmShift
{
    public int IdPmShift { get; set; }

    public int? IdPmEvent { get; set; }

    public string? LocationDescription { get; set; }

    public string? ShiftDescription { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? BreakDurationMinutes { get; set; }

    public int? RoleSerialNumber { get; set; }

    public int? NumWorkersRequired { get; set; }

    public string? AuditStamp { get; set; }
}
