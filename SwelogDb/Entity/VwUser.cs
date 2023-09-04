using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwUser
{
    public string WorkStation { get; set; } = null!;

    public string? SwelogUser { get; set; }

    public string NtDomain { get; set; } = null!;

    public string NtUsername { get; set; } = null!;

    public string LoginName { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
