using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class WindowPosition
{
    public string Classname { get; set; } = null!;

    public string WorkstationId { get; set; } = null!;

    public int? X { get; set; }

    public int? Y { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public bool? Maximize { get; set; }
}
