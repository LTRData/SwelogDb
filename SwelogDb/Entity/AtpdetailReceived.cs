using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AtpdetailReceived
{
    public decimal? Receipt { get; set; }

    public string? Item { get; set; }

    public DateTime? CalculationDate { get; set; }
}
