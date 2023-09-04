using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoestmtCurrentSelectionItem
{
    public string Item { get; set; } = null!;

    public int StrLevel { get; set; }

    public int Spid { get; set; }
}
