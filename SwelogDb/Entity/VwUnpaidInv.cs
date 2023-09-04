using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwUnpaidInv
{
    public string WhichType { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime? DueDate { get; set; }

    public string? SeriesNo { get; set; }

    public decimal? InvAmountBc { get; set; }

    public decimal? VatAmt { get; set; }
}
