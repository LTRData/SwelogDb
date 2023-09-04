using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PersonCatg
{
    public string PersonCatg1 { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? CategoryDesc { get; set; }

    public string? WageSystem { get; set; }

    public short? OutputOptions { get; set; }

    public short? TimePeriod { get; set; }

    public string? TotalAttendanceFlag { get; set; }

    public string? AttendanceWageType { get; set; }

    public string? NotCompensatedFlag { get; set; }

    public string? NotCompensatedWageType { get; set; }

    public string? HolidayCompensationFlag { get; set; }

    public string? HolidayWageType { get; set; }

    public string? ShiftCompensationFlag { get; set; }

    public decimal? ShiftCompensateMinutes { get; set; }

    public string? ShiftCompensateWageType { get; set; }

    public string? WorkTimeReduceFlag { get; set; }

    public decimal? WorkTimeReduceMinutes { get; set; }

    public string? WorkTimeReduceWageType { get; set; }

    public string? OvertimeInFlexi { get; set; }

    public string? ActivityTransactionFlag { get; set; }

    public string? ActivitySumIndicator { get; set; }

    public decimal? MinWageLimit { get; set; }

    public decimal? MaxWageLimit { get; set; }

    public string? AlarmPerActivity { get; set; }

    public string? AlarmPerPeriod { get; set; }

    public string? GrossWagePrintOption { get; set; }

    public short? GrossWagePrintCopies { get; set; }

    public string? AuditStamp { get; set; }

    public string? CalendarTransOption { get; set; }

    public string? MpcTransferInd { get; set; }

    public string? WagePrepInd { get; set; }

    public string? WageTypeForTimePay { get; set; }

    public string? TimePayFlag { get; set; }

    public string? WageTypeForAdvance { get; set; }

    public string? FlexiInOrdWorkingHours { get; set; }

    public string? WorkOnFreedayHandling { get; set; }
}
