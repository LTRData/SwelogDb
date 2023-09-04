using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ControlMaster
{
    public int ControlId { get; set; }

    public string? ControlTitle { get; set; }

    public string? ControlDescription { get; set; }

    public byte? StdRedValue { get; set; }

    public byte? StdYellowValue { get; set; }

    public int? StdMinValue { get; set; }

    public int? StdMaxValue { get; set; }
}
