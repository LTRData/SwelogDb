using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwCDelnotesAvailableForFreightnotesDtl
{
    public string? DelnoteKey { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string? PartnerId { get; set; }

    public string? DeliveryAddressId { get; set; }
}
