using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwCoMoCascade
{
    public string OrderNumber { get; set; } = null!;

    public short CoOrderLineNumber { get; set; }

    public string? CoItemNumber { get; set; }

    public string MoItemNumber { get; set; } = null!;

    public int MoLotNumber { get; set; }

    public int? IdReservation { get; set; }

    public string? GoodsMarking { get; set; }

    public string? ProjectNumber { get; set; }
}
