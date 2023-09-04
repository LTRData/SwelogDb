using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwEstimate
{
    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? ItemType { get; set; }

    public string? ItemCategory { get; set; }

    public string? ProductGroup { get; set; }

    public string? PreparationStatus { get; set; }

    public string? MarketStatus { get; set; }

    public string? CustomerId { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? AnnualRequirement { get; set; }

    public decimal? AnnualRequirementValue { get; set; }

    public decimal? LastYearIssue { get; set; }

    public decimal? LastYearIssueValue { get; set; }

    public decimal? CurrentYearReservation { get; set; }

    public decimal? CurrentYearIssue { get; set; }

    public DateTime? LastIssueDate { get; set; }
}
