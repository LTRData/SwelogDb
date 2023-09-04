using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogUser
{
    public string LoginId { get; set; } = null!;

    public string? IniFileName { get; set; }
}
