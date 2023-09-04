using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpShift
{
    public short ProcessId { get; set; }

    public int ShiftRow { get; set; }

    public string? ShiftCode { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? ShiftDesc { get; set; }

    public string? TimeModel { get; set; }

    public DateTime? ShiftStartTime { get; set; }

    public DateTime? StartFlexiFrom { get; set; }

    public DateTime? StartFlexiUpto { get; set; }

    public DateTime? ShiftEndTime { get; set; }

    public DateTime? EndFlexiFrom { get; set; }

    public DateTime? EndFlexiUpto { get; set; }

    public int? MaxFlexiPlus { get; set; }

    public int? MaxFlexiMinus { get; set; }

    public string? FlexiInWorkingHours { get; set; }

    public string? AutoAttestCodeType { get; set; }

    public string? AutoAttestCodeBeforeShift { get; set; }

    public short? AutoAttestMinutesBeforeShift { get; set; }

    public string? AutoAttestCodeAfterShift { get; set; }

    public short? AutoAttestMinutesAfterShift { get; set; }

    public string? ReportOption { get; set; }

    public string? BreakNormalFlag { get; set; }

    public int? BreakMinimum { get; set; }

    public string? HdrDtlInd { get; set; }

    public DateTime? ShiftDate { get; set; }

    public int? AttestedBy { get; set; }

    public string? HolidayWageInd { get; set; }
}
