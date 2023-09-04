using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwStructureWheeltablePosition
{
    public string ParentPart { get; set; } = null!;

    public int LotNumber { get; set; }

    public string ComponentPart { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string? WheeltablePosition { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? ReservationQuantityPart { get; set; }
}
