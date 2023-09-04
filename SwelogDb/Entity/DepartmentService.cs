using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DepartmentService
{
    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public int? EmploymentNumber { get; set; }

    public string? ReferenceId { get; set; }

    public string? DepartmentNumber { get; set; }

    public string? ResourceNumber { get; set; }

    public string? FreeText { get; set; }

    public string? MfgOrderNumber { get; set; }

    public string? Status { get; set; }

    public DateTime? ReactivatedDate { get; set; }

    public string? AuditStamp { get; set; }

    public int? LotNumber { get; set; }

    public string? MfgItemNumber { get; set; }
}
