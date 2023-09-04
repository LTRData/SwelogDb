using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PoSuggestLimit
{
    public string ItemNumber { get; set; } = null!;

    public byte WeekNumber { get; set; }

    public decimal? WeekLimit { get; set; }

    public byte? WeekFrozenUpto { get; set; }
}
