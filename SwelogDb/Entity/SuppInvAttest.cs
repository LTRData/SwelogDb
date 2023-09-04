using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvAttest
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string AttestType { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string DepartmentNo { get; set; } = null!;

    public string ReferenceId { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
