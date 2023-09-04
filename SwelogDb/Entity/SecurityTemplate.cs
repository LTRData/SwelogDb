using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SecurityTemplate
{
    public string Window { get; set; } = null!;

    public string Control { get; set; } = null!;

    public string? Dynamic { get; set; }

    public string? Description { get; set; }

    public string? ObjectType { get; set; }
}
