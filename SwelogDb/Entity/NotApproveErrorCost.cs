using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NotApproveErrorCost
{
    public int RecordSerial { get; set; }

    public string ErrorReportId { get; set; } = null!;

    public string ReportType { get; set; } = null!;

    public DateTime ReportDate { get; set; }

    public string? ReportIdentification { get; set; }

    public decimal Cost { get; set; }

    public string? AdditionalInformation { get; set; }

    public virtual NotApproveErrorReport ErrorReport { get; set; } = null!;
}
