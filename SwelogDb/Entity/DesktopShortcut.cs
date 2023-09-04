using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DesktopShortcut
{
    public string UserId { get; set; } = null!;

    public int ShortcutNumber { get; set; }

    public int? ShortcutType { get; set; }

    public string? PicturePath { get; set; }

    public string? ShortText { get; set; }

    public string? SearchPath { get; set; }

    public string? MenuName { get; set; }

    public DateTime? AlarmDatetime { get; set; }
}
