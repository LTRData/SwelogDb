using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class KpiHeader
{
    public string UserId { get; set; } = null!;

    public byte? StartViewNumber { get; set; }

    public byte? RefreshInterval { get; set; }

    public bool? SlideShow { get; set; }
}
