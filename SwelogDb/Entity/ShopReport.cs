using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ShopReport
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public string? JobStatus { get; set; }

    public DateTime? StartFinishDate { get; set; }
}
