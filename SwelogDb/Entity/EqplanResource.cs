using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EqplanResource
{
    public int SerialNumber { get; set; }

    public string? ResourceNumber { get; set; }

    public bool? SendToEqplan { get; set; }

    public bool? AllowOverlap { get; set; }
}
