using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpTraceList
{
    public int? ProcesssId { get; set; }

    public string? PalletNo { get; set; }

    public string? ExtraInfo { get; set; }

    public string? HelpInfo { get; set; }
}
