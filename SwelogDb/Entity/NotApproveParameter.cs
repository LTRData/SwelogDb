using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NotApproveParameter
{
    public string CompanyId { get; set; } = null!;

    public int? ReviewUnitCostLimit { get; set; }

    public int? ReviewTotalCostLimit { get; set; }

    public int? StatisticUnitCostLimit { get; set; }

    public int? StatisticTotalCostLimit { get; set; }

    public int? DismountUnitCostLimit { get; set; }

    public int? DismountTotalCostLimit { get; set; }

    public string? SortOrder { get; set; }

    public byte? Action1Days { get; set; }

    public byte? Action2Days { get; set; }

    public byte? Action3Days { get; set; }

    public byte? Action4Days { get; set; }

    public byte? Action5Days { get; set; }

    public byte? Action6Days { get; set; }

    public byte? Action7Days { get; set; }

    public byte? Action8Days { get; set; }

    public string? DeductRejQtyFromOrdQtyInAtpYn { get; set; }

    public string? CalculateCostAtRetrievalYn { get; set; }

    public string? PrintDeviationPalletLabel { get; set; }
}
