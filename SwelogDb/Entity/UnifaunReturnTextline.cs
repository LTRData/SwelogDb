using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class UnifaunReturnTextline
{
    public int IdUnifaunReturnTextlines { get; set; }

    public int? Spid { get; set; }

    public string? Textline { get; set; }
}
