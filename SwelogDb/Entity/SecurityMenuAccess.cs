using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SecurityMenuAccess
{
    public string Name { get; set; } = null!;

    public string Menu { get; set; } = null!;

    public string Access { get; set; } = null!;

    public string Permission { get; set; } = null!;

    public string? GroupName { get; set; }
}
