using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class IntmesgUserProfile
{
    public string UserId { get; set; } = null!;

    public bool? AllowCreate { get; set; }

    public bool? AllowReply { get; set; }

    public bool? AllowForward { get; set; }

    public bool? AllowDelete { get; set; }

    public bool? InformAtLogon { get; set; }

    public bool? InformAtTerminal { get; set; }

    public bool? InformImmediately { get; set; }

    public string? IsNotUser { get; set; }
}
