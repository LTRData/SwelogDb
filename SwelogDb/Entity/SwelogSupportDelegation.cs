using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogSupportDelegation
{
    public string ModuleId { get; set; } = null!;

    public string? EmailId { get; set; }
}
