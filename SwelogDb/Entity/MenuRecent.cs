using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MenuRecent
{
    public string UserId { get; set; } = null!;

    public DateTime AccessDatetime { get; set; }

    public string? MenuName { get; set; }

    public string? MenuText { get; set; }
}
