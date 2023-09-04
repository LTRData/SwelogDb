using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ItemEcnNumberHistory
{
    public int IdItemEcnNumberHistory { get; set; }

    public string ItemNumber { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public string? EcnNumber { get; set; }

    public string? UserId { get; set; }
}
