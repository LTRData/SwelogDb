using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WindowIdentifier
{
    public string Classname { get; set; } = null!;

    public int WindowIdentity { get; set; }

    public int? RefreshInterval { get; set; }
}
