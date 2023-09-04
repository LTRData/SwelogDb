using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ArrivalInspectionControlText
{
    public string InspectionId { get; set; } = null!;

    public short InspectionSerial { get; set; }

    public string ControlTextCode { get; set; } = null!;

    public string? ApprovedYn { get; set; }

    public string? Comment { get; set; }

    public string? AuditStamp { get; set; }
}
