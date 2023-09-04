using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class AtpdetailSuggestionsNew
{
    public DateTime? OrderDate { get; set; }

    public int? OrderDateCcyywwd { get; set; }

    public string TransType { get; set; } = null!;

    public string? OrderNo { get; set; }

    public string Customer { get; set; } = null!;

    public string? Supplier { get; set; }

    public string? ItemOwner { get; set; }

    public decimal? Receipt { get; set; }

    public decimal? Reserved { get; set; }

    public string? Item { get; set; }

    public DateTime? CalculationDate { get; set; }

    public string DelAddr { get; set; } = null!;

    public string OrderStatus { get; set; } = null!;

    public string CostCentre { get; set; } = null!;

    public string? Code { get; set; }
}
