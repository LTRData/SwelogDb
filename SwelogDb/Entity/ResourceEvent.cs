using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResourceEvent
{
    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDateTime { get; set; }

    public string ActivityNo { get; set; } = null!;

    public string EventId { get; set; } = null!;

    public int? ReportedBy { get; set; }

    public string? InterruptCode { get; set; }

    public string? AuditStamp { get; set; }

    public string ActivityType { get; set; } = null!;

    public int SequenceNo { get; set; }

    public int? AttestedBy { get; set; }

    public DateTime? AttestedDateTime { get; set; }

    public string? BonusFlag { get; set; }

    public int? InterruptCounter { get; set; }

    public int? InterruptMinutes { get; set; }

    public string? InterruptFreeText { get; set; }

    public string? ToolNumber { get; set; }

    public string? ModuleId { get; set; }
}
