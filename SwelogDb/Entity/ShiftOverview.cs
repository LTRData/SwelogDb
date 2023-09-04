using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ShiftOverview
{
    public int EmploymentNo { get; set; }

    public DateTime ShiftDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? End { get; set; }

    public int? MaxFlexiPlus { get; set; }

    public int? MaxFlexiMinus { get; set; }

    public int? FlexiBankPlus { get; set; }

    public int? FlexiBankMinus { get; set; }

    public string? WkSchedule { get; set; }

    public string? CompSch { get; set; }

    public string? ExtraCompSch { get; set; }

    public string? WorkFreeDay { get; set; }

    public string? ShiftIndicator { get; set; }

    public string? TimeCategory { get; set; }

    public string? PersonCatg { get; set; }

    public string? HolidayWageInd { get; set; }

    public string? TimeModel { get; set; }

    public string? AbsenceCode { get; set; }

    public double? WorkingHours { get; set; }

    public DateTime? LatestStart { get; set; }

    public DateTime? EarliestEnd { get; set; }

    public string? FlexiInWorkingHours { get; set; }

    public string? AutoAttestCodeType { get; set; }

    public string? AutoAttestCodeBeforeShift { get; set; }

    public short? AutoAttestMinutesBeforeShift { get; set; }

    public string? AutoAttestCodeAfterShift { get; set; }

    public short? AutoAttestMinutesAfterShift { get; set; }

    public DateTime? EndDateTime { get; set; }

    public string? WorkOnFreedayAbsenceCode { get; set; }
}
