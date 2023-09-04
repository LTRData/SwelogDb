using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletStatus
{
    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? MrpAvailable { get; set; }

    public string? MfgAvailable { get; set; }
}
