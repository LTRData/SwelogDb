using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReservationPosition
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public string ComponentPart { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string PositionIndicator { get; set; } = null!;

    public string? DrawingNo { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public decimal? FixedUsage { get; set; }

    public string? MfgOrderLine { get; set; }
}
