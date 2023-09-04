using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MergedFreight
{
    public int IdMergedFreight { get; set; }

    public string MainDeliveryNote { get; set; } = null!;

    public string MergedDeliveryNote { get; set; } = null!;

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public string? MainDeliveryNoteId { get; set; }

    public string? MergedDeliveryNoteId { get; set; }
}
