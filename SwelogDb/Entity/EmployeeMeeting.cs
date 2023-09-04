using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EmployeeMeeting
{
    public int EmploymentNumber { get; set; }

    public string MeetingNo { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
