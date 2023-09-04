using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TpOperationCostSpecification
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string? ResourceNumber { get; set; }

    public decimal? OperationTime { get; set; }

    public decimal? ResourceTime { get; set; }

    public decimal? HiredOperationCost { get; set; }

    public decimal? DirectWageCost { get; set; }

    public decimal? SetupCost { get; set; }

    public decimal? SocialCost { get; set; }

    public decimal? MfgOverheadCost { get; set; }

    public decimal? CurrentTotalCost { get; set; }

    public decimal? HiredSetupCost { get; set; }

    public decimal? HiredOverheadCost { get; set; }

    public decimal? OperatorSetupTime { get; set; }

    public decimal? ResourceSetupTime { get; set; }

    public decimal? SetupCostPSetup { get; set; }

    public decimal? SocialCostPSetup { get; set; }

    public decimal? MfgOverheadCostPSetup { get; set; }

    public decimal? SocialCostSetup { get; set; }

    public decimal? SocialCostPrd { get; set; }

    public decimal? MfgOverheadCostSetup { get; set; }

    public decimal? MfgOverheadCostPrd { get; set; }

    public decimal? MfgOverheadCostFixed { get; set; }

    public decimal? MfgOverheadCostVariable { get; set; }

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

    public decimal? SetupCostPSetup2 { get; set; }

    public decimal? SocialCostPSetup2 { get; set; }

    public decimal? MfgOverheadCostPSetup2 { get; set; }

    public decimal? TotSetupPiece2 { get; set; }

    public decimal? PurchaseOverheadCost { get; set; }

    public decimal? ResFinancialCost { get; set; }

    public decimal? ResFinancialCostSetup { get; set; }

    public decimal? ResFinancialCostPerSetup { get; set; }

    public decimal? TotaccumComponentCost { get; set; }

    public decimal? TotaccumWagecost { get; set; }

    public decimal? TotaccumOther { get; set; }

    public decimal? ResDepresCost { get; set; }

    public decimal? ResDepresCostSetup { get; set; }

    public decimal? ResDepresCostPerSetup { get; set; }

    public decimal? ResReobtainaddCost { get; set; }

    public decimal? ResReobtainaddCostSetup { get; set; }

    public decimal? ResReobtainaddCostPerSetup { get; set; }

    public decimal? TotaccumAlloyCost { get; set; }
}
