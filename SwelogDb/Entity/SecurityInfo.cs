using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SecurityInfo
{
    public string Window { get; set; } = null!;

    public string Control { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;
}
