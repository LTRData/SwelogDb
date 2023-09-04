using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOrderPicklistHeader
{
    public int PicklistNumber { get; set; }

    public DateTime? PicklistDate { get; set; }

    public string? MfgOrderLine { get; set; }

    public string? OperationNumberList { get; set; }

    public string? Status { get; set; }

    public string? AuditStamp { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ReportDate { get; set; }

    public string? ReportedBy { get; set; }
}
