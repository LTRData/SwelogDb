using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ShiftMain
{
    public string ShiftCode { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? ShiftDesc { get; set; }

    public string? TimeModel { get; set; }

    public DateTime? ShiftStartTime { get; set; }

    public DateTime? StartFlexiFrom { get; set; }

    public DateTime? StartFlexiUpto { get; set; }

    public DateTime? ShiftEndTime { get; set; }

    public DateTime? EndFlexiFrom { get; set; }

    public DateTime? EndFlexiUpto { get; set; }

    public string? AuditStamp { get; set; }

    public int? MaxFlexiPlus { get; set; }

    public int? MaxFlexiMinus { get; set; }

    public string? FlexiInWorkingHours { get; set; }

    public string? AutoAttestCodeType { get; set; }

    public string? AutoAttestCodeBeforeShift { get; set; }

    public short? AutoAttestMinutesBeforeShift { get; set; }

    public string? AutoAttestCodeAfterShift { get; set; }

    public short? AutoAttestMinutesAfterShift { get; set; }
}
