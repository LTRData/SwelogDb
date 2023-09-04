using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SecurityMdiMenu
{
    public string Menu { get; set; } = null!;

    public string? Description { get; set; }

    public string? Window { get; set; }

    public int? MenuId { get; set; }

    public string? MenuNo { get; set; }

    public string? Access { get; set; }
}
