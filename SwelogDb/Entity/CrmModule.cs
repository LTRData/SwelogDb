using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmModule
{
    public string ModuleName { get; set; } = null!;

    public bool? AllowedFlag { get; set; }
}
