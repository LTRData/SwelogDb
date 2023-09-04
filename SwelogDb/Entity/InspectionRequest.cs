using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InspectionRequest
{
    public int IdInspectionRequest { get; set; }

    public string? ItemNumber { get; set; }

    public string? ControlId { get; set; }

    public string? ParentItemNumber { get; set; }

    public string? MfgOrderNumber { get; set; }

    public string? RequestedBy { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public string? RequestStatus { get; set; }
}
