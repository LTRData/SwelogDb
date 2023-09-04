using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmSecurityMaster
{
    public string OptionName { get; set; } = null!;

    public bool? AllowedFlag { get; set; }
}
