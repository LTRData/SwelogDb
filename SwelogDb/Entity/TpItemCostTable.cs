using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TpItemCostTable
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public decimal? RawMaterialCost { get; set; }

    public decimal? RawMaterialOverhead { get; set; }

    public decimal? PurchaseItemCost { get; set; }

    public decimal? PurchaseFixedOrderCost { get; set; }

    public decimal? PurchaseOverheadCost { get; set; }

    public decimal? DirectWageCost { get; set; }

    public decimal? MfgSetupCost { get; set; }

    public decimal? MfgOverheadCost { get; set; }

    public decimal? CurrentTotalCost { get; set; }

    public decimal? TotalWeight { get; set; }

    public decimal? SocialCost { get; set; }

    public decimal? SetupCostPSetup { get; set; }

    public decimal? SocialCostPSetup { get; set; }

    public decimal? MfgOverheadCostPSetup { get; set; }

    public decimal? SocialCostSetup { get; set; }

    public decimal? SocialCostPrd { get; set; }

    public decimal? MfgOverheadCostSetup { get; set; }

    public decimal? MfgOverheadCostPrd { get; set; }

    public decimal? MfgOverheadCostFixed { get; set; }

    public decimal? MfgOverheadCostVariable { get; set; }

    public decimal? ParentQuantity { get; set; }

    public string? ParentUom { get; set; }

    public decimal? SetupCostPSetup2 { get; set; }

    public decimal? SocialCostPSetup2 { get; set; }

    public decimal? MfgOverheadCostPSetup2 { get; set; }

    public decimal? SpeccostMatfreight { get; set; }

    public decimal? SpeccostPurchoprfreightEu { get; set; }

    public decimal? SpeccostPurchoprfreightSv { get; set; }

    public decimal? SpeccostCustfreight { get; set; }

    public decimal? SpeccostRework { get; set; }

    public decimal? SpeccostRejection { get; set; }

    public decimal? SpeccostToolservice { get; set; }

    public decimal? SpeccostReworkAdd { get; set; }

    public decimal? SpeccostRejectionAdd { get; set; }

    public decimal? SpeccostToolserviceAdd { get; set; }

    public decimal? TotSetupPiece2 { get; set; }

    public decimal? ResFinancialCost { get; set; }

    public decimal? ResFinancialCostSetup { get; set; }

    public decimal? ResFinancialCostPerSetup { get; set; }

    public decimal? ResDepresCost { get; set; }

    public decimal? ResDepresCostSetup { get; set; }

    public decimal? ResDepresCostPerSetup { get; set; }

    public decimal? ResReobtainaddCost { get; set; }

    public decimal? ResReobtainaddCostSetup { get; set; }

    public decimal? ResReobtainaddCostPerSetup { get; set; }

    public DateTime? CalculationDate { get; set; }

    public decimal? AlloyCost { get; set; }

    public decimal? AdministrationPercentage { get; set; }

    public decimal? ProfitPercentage { get; set; }
}
