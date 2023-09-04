using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class IndividualDeviation
{
    public int EmploymentNo { get; set; }

    public DateTime ShiftDate { get; set; }

    public string? ShiftCode { get; set; }

    public string? TimeModel { get; set; }

    public string? WorkFreeDay { get; set; }

    public string? HolidayWageInd { get; set; }

    public DateTime? ShiftStartTime { get; set; }

    public DateTime? StartFlexiFrom { get; set; }

    public DateTime? StartFlexiUpto { get; set; }

    public DateTime? ShiftEndTime { get; set; }

    public DateTime? EndFlexiFrom { get; set; }

    public DateTime? EndFlexiUpto { get; set; }

    public int? MaxFlexiPlus { get; set; }

    public int? MaxFlexiMinus { get; set; }

    public int? AttestedBy { get; set; }

    public string? AuditStamp { get; set; }

    public int? WorkAsEmployee { get; set; }

    public string? WorkAsTimeCatg { get; set; }

    public string? FlexiInWorkingHours { get; set; }

    public string? StartPrevDay { get; set; }
}
