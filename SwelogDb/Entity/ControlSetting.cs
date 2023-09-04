using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ControlSetting
{
    public string UserId { get; set; } = null!;

    public byte ControlNumber { get; set; }

    public byte ControlId { get; set; }

    public byte? RedValue { get; set; }

    public byte? YellowValue { get; set; }

    public int? MinValue { get; set; }

    public int? MaxValue { get; set; }

    public string? AuditStamp { get; set; }
}
