using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EqplanColor
{
    public int SerialNumber { get; set; }

    public int? ForegroundColorRgb { get; set; }

    public int? BackgroundColorRgb { get; set; }
}
