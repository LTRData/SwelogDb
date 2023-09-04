using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PoSuggestLimitDetail
{
    public string ComponentItemNumber { get; set; } = null!;

    public DateTime? DemandDate { get; set; }

    public decimal? DemandQuantity { get; set; }

    public string? DemandId { get; set; }

    public string? ComponentItemType { get; set; }

    public string? ComponentCostCentre { get; set; }

    public string? ComponentPlannerId { get; set; }
}
