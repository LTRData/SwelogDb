using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwEmployee
{
    public int EmploymentNumber { get; set; }

    public string? EmployeeName { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? ReferenceId { get; set; }

    public string? DonotShow { get; set; }
}
