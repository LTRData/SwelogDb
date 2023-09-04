using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SecurityReport
{
    public int SerialNumber { get; set; }

    public string? UserIdOrGroup { get; set; }

    public bool? UserOrGroupIndicator { get; set; }

    public string? DisallowedReportId { get; set; }
}
