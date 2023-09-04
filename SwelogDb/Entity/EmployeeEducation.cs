using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeEducation
{
    public int IdEmployeeEducation { get; set; }

    public int EmploymentNumber { get; set; }

    public string? EducationId { get; set; }

    public string? EducationName { get; set; }

    public short? Status { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? UptoDate { get; set; }

    public int? NumOfHours { get; set; }

    public string? Certification { get; set; }

    public string? Purpose { get; set; }

    public string? FollowUpYn { get; set; }

    public DateTime? FollowUpDate { get; set; }

    public int? ValidityPeriod { get; set; }

    public string? LongText { get; set; }

    public string? AuditStamp { get; set; }
}
