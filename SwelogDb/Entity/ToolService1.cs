using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolService1
{
    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public int? EmploymentNumber { get; set; }

    public string? ReferenceId { get; set; }

    public string? ToolNumber { get; set; }

    public string? ToolReactivateType { get; set; }

    public string? FreeText { get; set; }

    public string? ToolOrderNumber { get; set; }

    public string? Status { get; set; }

    public DateTime? ReactivatedDate { get; set; }

    public string? AuditStamp { get; set; }

    public int? LotNumber { get; set; }

    public short? ToolSerialNumber { get; set; }

    public string? ProjectNumber { get; set; }
}
