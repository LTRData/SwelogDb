using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ViaForwardDeliveryPallet
{
    public int IdViaForwardDeliveryPallet { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? ItemNumber { get; set; }

    public string? PalletNo { get; set; }

    public decimal? Qty { get; set; }

    public string? DeliveredYn { get; set; }

    public string? EdiDelnoteNo { get; set; }
}
