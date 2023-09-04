using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PsProductivityTarget
{
    public string KeyType { get; set; } = null!;

    public string KeyId { get; set; } = null!;

    public int Year { get; set; }

    public int Week { get; set; }

    public decimal? ProductivityTarget { get; set; }

    public decimal? IndirectTimeTarget { get; set; }
}
