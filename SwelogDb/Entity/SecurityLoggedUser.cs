using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SecurityLoggedUser
{
    public string UserId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public DateTime LoginDate { get; set; }

    public DateTime LoginTime { get; set; }

    public string NetworkWorkstation { get; set; } = null!;

    public int ValidStatus { get; set; }

    public int InvalidateCount { get; set; }
}
