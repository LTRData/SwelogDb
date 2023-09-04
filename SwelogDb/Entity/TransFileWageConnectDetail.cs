using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TransFileWageConnectDetail
{
    public int IdTransFileWageConnectDetail { get; set; }

    public string WageCategory { get; set; } = null!;

    public string WagePeriod { get; set; } = null!;

    public int? EmploymentNumber { get; set; }

    public DateTime? FromDateTime { get; set; }

    public DateTime? UptoDateTime { get; set; }

    public string? WageType { get; set; }

    public string? WageSpec { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Price { get; set; }

    public string? AuditStamp { get; set; }

    public string? WageTypeSum { get; set; }

    public string? AbsenceFlag { get; set; }

    public string? AttendanceIndicator { get; set; }

    public string? OvertimeAbsenceCode { get; set; }
}
