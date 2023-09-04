using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PalletTemp
{
    public int Sno { get; set; }

    public string PacklistNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string? PalletNumber { get; set; }

    public decimal? Quantity { get; set; }

    public string? PackType { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public string? DeliveryNoteNumber { get; set; }
}
