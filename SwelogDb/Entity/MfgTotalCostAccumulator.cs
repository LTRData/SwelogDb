using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgTotalCostAccumulator
{
    public string ItemNumber { get; set; } = null!;

    public int? LotNumber { get; set; }

    public string? MfgOrderType { get; set; }

    public int YearNo { get; set; }

    public int MonthNo { get; set; }

    public string? Resource { get; set; }

    public string? CostCentre { get; set; }

    public decimal? MfgTotalCost { get; set; }

    public string? ItemDescription { get; set; }

    public short? OperationNumber { get; set; }

    public int? EmployeeNumber { get; set; }

    public DateTime? ReportDatetime { get; set; }

    public decimal? OperatorTime { get; set; }

    public decimal? OperatorSetupTime { get; set; }

    public decimal? QuantityProduced { get; set; }

    public short? NoOfSetup { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? EmployeeName { get; set; }

    public decimal? ResourceRate { get; set; }

    public int RecId { get; set; }

    public decimal? OperationCost { get; set; }

    public decimal? MaterialCost { get; set; }

    public decimal? PurchaseCost { get; set; }

    public int? TrnType { get; set; }

    public string? OrderNumber { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNumber { get; set; }

    public string? GoodsentryNumber { get; set; }

    public string? QuantityFormat { get; set; }

    public decimal? PurchaseOperationCost { get; set; }

    public string? ComponentCode { get; set; }

    public string? MfgOrderTypeText { get; set; }

    public string? ProductNo { get; set; }

    public string? ProductGroup { get; set; }

    public decimal? OrderedCost { get; set; }

    public string? SparepartItemNumber { get; set; }

    public string? SparepartItemDescription { get; set; }
}
