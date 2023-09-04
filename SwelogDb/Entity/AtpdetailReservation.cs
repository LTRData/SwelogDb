using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AtpdetailReservation
{
    public decimal? Reserved { get; set; }

    public string Item { get; set; } = null!;

    public DateTime CalculationDate { get; set; }
}
