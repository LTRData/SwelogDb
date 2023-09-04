using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoestmtExcel170
{
    public string EcoestmtType { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? StockingUnit { get; set; }

    public string? UomFormat { get; set; }

    public string? CurrencyFormat { get; set; }

    public decimal? AnnualRequirement { get; set; }

    public int? SetupsPerYear { get; set; }

    public decimal? LotSize { get; set; }

    public decimal? CostPricePerUnit { get; set; }

    public decimal? SellingPricePerUnit { get; set; }

    public decimal? SeperateOrderCost { get; set; }

    public decimal? RawMaterialCost { get; set; }

    public decimal? PurchaseItemCost { get; set; }

    public decimal? MfgOverheadCost { get; set; }

    public decimal? DirectWageCost { get; set; }

    public decimal? SocialCost { get; set; }

    public decimal? MfgOverheadCostFixed { get; set; }

    public decimal? MfgOverheadCostVariable { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? SetupCost { get; set; }

    public decimal? Qty1Rawmaterial { get; set; }

    public decimal? Qty1Purchaseitemcost { get; set; }

    public decimal? Qty1Purchaseoperationcost { get; set; }

    public decimal? Qty1Totalmaterialcost { get; set; }

    public decimal? Qty1Mfgoverheadcost { get; set; }

    public decimal? Qty1Mfgoverheadcostpercent { get; set; }

    public decimal? Qty1Totalextracosts { get; set; }

    public decimal? Qty1Setupcost { get; set; }

    public decimal? Qty1Totalprodcost { get; set; }

    public decimal? Qty1Totalcost { get; set; }

    public decimal? Qty1Affo { get; set; }

    public decimal? Qty1Affosetup { get; set; }

    public decimal? Qty1Totalsetupcost { get; set; }

    public decimal? Qty1Totalselfcost { get; set; }

    public decimal? Qty1Profitoh { get; set; }

    public decimal? Qty1Profitohsetup { get; set; }

    public decimal? Qty1Calculatedsetupcost { get; set; }

    public decimal? Qty1Calculatedprice { get; set; }

    public decimal? Qty1Separateordercost { get; set; }

    public decimal? Qty1Diff1 { get; set; }

    public decimal? Qty1Sellingprice { get; set; }

    public decimal? Qty1Diff2 { get; set; }

    public decimal? Qty1Tb1 { get; set; }

    public decimal? Qty1Tb1percent { get; set; }

    public decimal? Qty1Tb2 { get; set; }

    public decimal? Qty1Tb2percent { get; set; }

    public decimal? Qty1Tb3 { get; set; }

    public decimal? Qty1Tb3percent { get; set; }

    public decimal? Qty1Profit { get; set; }

    public decimal? Qty1Profitpercent { get; set; }

    public string? ViewYn { get; set; }

    public string? ProductGroup { get; set; }

    public string? ItemType1 { get; set; }

    public string? ItemType2 { get; set; }

    public string? ItemStatus1 { get; set; }
}
