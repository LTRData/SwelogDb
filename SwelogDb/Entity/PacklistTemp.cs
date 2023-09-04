using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PacklistTemp
{
    public int Sno { get; set; }

    public string? PacklistNumber { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? PalletBox { get; set; }

    public decimal? Quantity { get; set; }

    public string? PackType { get; set; }
}
