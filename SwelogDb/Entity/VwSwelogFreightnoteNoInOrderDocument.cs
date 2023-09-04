using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwSwelogFreightnoteNoInOrderDocument
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string DelnoteNo { get; set; } = null!;

    public string FreightnoteNo { get; set; } = null!;

    public string? FreightNote { get; set; }

    public string? UnifaunReturnSendingId { get; set; }
}
