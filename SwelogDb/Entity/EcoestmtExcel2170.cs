using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoestmtExcel2170
{
    public string EcoestmtType { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string LotNumber { get; set; } = null!;

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

    public DateTime? CalcDate { get; set; }

    public decimal? StkRawmaterial { get; set; }

    public decimal? StkPurchaseitemcost { get; set; }

    public decimal? StkSpeccostMatfreight { get; set; }

    public decimal? StkPurchaseopercost { get; set; }

    public decimal? StkSpeccostPurchfreightEu { get; set; }

    public decimal? StkSpeccostPurchfreightSe { get; set; }

    public decimal? StkMfgoverheadcost { get; set; }

    public decimal? StkMfgoverheadcostpercent { get; set; }

    public decimal? StkTotalmaterialcost { get; set; }

    public decimal? StkSalary { get; set; }

    public decimal? StkSpeccostRework { get; set; }

    public decimal? StkSpeccostRejection { get; set; }

    public decimal? StkSpeccostToolservice { get; set; }

    public decimal? StkSetupcost1 { get; set; }

    public decimal? StkTotalextracosts { get; set; }

    public decimal? StkTopercent { get; set; }

    public decimal? StkSetupcost2 { get; set; }

    public decimal? StkTotalproductioncost { get; set; }

    public decimal? StkTotalcost { get; set; }

    public decimal? StkResourceLeasingWoSetup { get; set; }

    public decimal? StkResourceLeasingSetup { get; set; }

    public decimal? StkResourceLeasing { get; set; }

    public decimal? StkStockValue { get; set; }

    public decimal? StkAffo { get; set; }

    public decimal? StkAffosetup { get; set; }

    public decimal? StkTotalselfcostExclDepresSetup { get; set; }

    public decimal? StkTotalselfcostExclDepres { get; set; }

    public decimal? StkSpeccostCustfreight { get; set; }

    public decimal? StkResourceDepresWoSetup { get; set; }

    public decimal? StkResourceDepresSetup { get; set; }

    public decimal? StkResourceDepres { get; set; }

    public decimal? StkTotalselfcostInclDepresSetup { get; set; }

    public decimal? StkTotalselfcostInclDepres { get; set; }

    public decimal? StkSetupProfitAdd { get; set; }

    public decimal? StkProfitAdd { get; set; }

    public decimal? StkSetupCalcpriceExclReobtain { get; set; }

    public decimal? StkCalcpriceExclReobtain { get; set; }

    public decimal? StkResourceReobtainSetup { get; set; }

    public decimal? StkResourceReobtain { get; set; }

    public decimal? StkSetupTotalselfcostInclReobtain { get; set; }

    public decimal? StkTotalselfcostInclReobtain { get; set; }

    public decimal? StkSetupCalcprice { get; set; }

    public decimal? StkCalcprice { get; set; }

    public decimal? StkCalcpriceWoSetup { get; set; }

    public decimal? StkAddedvalue { get; set; }

    public decimal? StkSeparateordercost { get; set; }

    public decimal? StkDiff1 { get; set; }

    public decimal? StkSellingprice { get; set; }

    public decimal? StkDiff2 { get; set; }

    public decimal? StkTb1 { get; set; }

    public decimal? StkTb1percent { get; set; }

    public decimal? StkTb2 { get; set; }

    public decimal? StkTb2percent { get; set; }

    public decimal? StkTb2Writeoff { get; set; }

    public decimal? StkTb2Writeoffpercent { get; set; }

    public decimal? StkTb3 { get; set; }

    public decimal? StkTb3percent { get; set; }

    public decimal? StkTbInclDepres { get; set; }

    public decimal? StkTbInclDepresPerc { get; set; }

    public decimal? StkTbInclEbitProfit { get; set; }

    public decimal? StkTbInclEbitProfitPerc { get; set; }

    public decimal? StkProfit { get; set; }

    public decimal? StkProfitpercent { get; set; }

    public decimal? ProgRawmaterial { get; set; }

    public decimal? ProgPurchaseitemcost { get; set; }

    public decimal? ProgSpeccostMatfreight { get; set; }

    public decimal? ProgPurchaseopercost { get; set; }

    public decimal? ProgSpeccostPurchfreightEu { get; set; }

    public decimal? ProgSpeccostPurchfreightSe { get; set; }

    public decimal? ProgMfgoverheadcost { get; set; }

    public decimal? ProgMfgoverheadcostpercent { get; set; }

    public decimal? ProgTotalmaterialcost { get; set; }

    public decimal? ProgSalary { get; set; }

    public decimal? ProgSpeccostRework { get; set; }

    public decimal? ProgSpeccostRejection { get; set; }

    public decimal? ProgSpeccostToolservice { get; set; }

    public decimal? ProgSetupcost1 { get; set; }

    public decimal? ProgTotalextracosts { get; set; }

    public decimal? ProgTopercent { get; set; }

    public decimal? ProgSetupcost2 { get; set; }

    public decimal? ProgTotalproductioncost { get; set; }

    public decimal? ProgTotalcost { get; set; }

    public decimal? ProgResourceLeasingWoSetup { get; set; }

    public decimal? ProgResourceLeasingSetup { get; set; }

    public decimal? ProgResourceLeasing { get; set; }

    public decimal? ProgStockValue { get; set; }

    public decimal? ProgAffo { get; set; }

    public decimal? ProgAffosetup { get; set; }

    public decimal? ProgTotalselfcostExclDepresSetup { get; set; }

    public decimal? ProgTotalselfcostExclDepres { get; set; }

    public decimal? ProgSpeccostCustfreight { get; set; }

    public decimal? ProgResourceDepresWoSetup { get; set; }

    public decimal? ProgResourceDepresSetup { get; set; }

    public decimal? ProgResourceDepres { get; set; }

    public decimal? ProgTotalselfcostInclDepresSetup { get; set; }

    public decimal? ProgTotalselfcostInclDepres { get; set; }

    public decimal? ProgSetupProfitAdd { get; set; }

    public decimal? ProgProfitAdd { get; set; }

    public decimal? ProgSetupCalcpriceExclReobtain { get; set; }

    public decimal? ProgCalcpriceExclReobtain { get; set; }

    public decimal? ProgResourceReobtainSetup { get; set; }

    public decimal? ProgResourceReobtain { get; set; }

    public decimal? ProgSetupTotalselfcostInclReobtain { get; set; }

    public decimal? ProgTotalselfcostInclReobtain { get; set; }

    public decimal? ProgSetupCalcprice { get; set; }

    public decimal? ProgCalcprice { get; set; }

    public decimal? ProgCalcpriceWoSetup { get; set; }

    public decimal? ProgAddedvalue { get; set; }

    public decimal? ProgSeparateordercost { get; set; }

    public decimal? ProgDiff1 { get; set; }

    public decimal? ProgSellingprice { get; set; }

    public decimal? ProgDiff2 { get; set; }

    public decimal? ProgTb1 { get; set; }

    public decimal? ProgTb1percent { get; set; }

    public decimal? ProgTb2 { get; set; }

    public decimal? ProgTb2percent { get; set; }

    public decimal? ProgTb2Writeoff { get; set; }

    public decimal? ProgTb2Writeoffpercent { get; set; }

    public decimal? ProgTb3 { get; set; }

    public decimal? ProgTb3percent { get; set; }

    public decimal? ProgTbInclDepres { get; set; }

    public decimal? ProgTbInclDepresPerc { get; set; }

    public decimal? ProgTbInclEbitProfit { get; set; }

    public decimal? ProgTbInclEbitProfitPerc { get; set; }

    public decimal? ProgProfit { get; set; }

    public decimal? ProgProfitpercent { get; set; }
}
