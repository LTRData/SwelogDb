using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DesktopConfig
{
    public string UserId { get; set; } = null!;

    public string? PicturePath { get; set; }

    public int? ColorScheme { get; set; }
}
