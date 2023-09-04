using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CalculationDifference
{
    public DateTime CreatedAt { get; set; }

    public string ProductCategory { get; set; } = null!;

    public string ProductGroup { get; set; } = null!;

    public string ProductAccountCode { get; set; } = null!;

    public string StoreLocation { get; set; } = null!;

    public decimal? OperatorCostActual { get; set; }

    public decimal? OperatorSetupCostActual { get; set; }

    public decimal? MfgOverheadCostActual { get; set; }

    public decimal? PurchaseCostActual { get; set; }

    public decimal? PurchaseOverheadCostActual { get; set; }

    public decimal? RawMaterialCostComponent { get; set; }

    public decimal? PurchaseCostComponent { get; set; }

    public decimal? PurchaseOverheadCostComponent { get; set; }

    public decimal? OperatorCostComponent { get; set; }

    public decimal? OperatorSetupCostComponent { get; set; }

    public decimal? MfgOverheadCostComponent { get; set; }

    public DateTime? EventDate { get; set; }

    public decimal? TransferJnlYearNo { get; set; }

    public string? TransferJnlSeries { get; set; }

    public decimal? TransferJnlVoucherNo { get; set; }

    public string? AccountJnlSeries { get; set; }

    public decimal? AccountJnlVoucherNo { get; set; }
}
