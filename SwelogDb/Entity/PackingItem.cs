using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PackingItem
{
    public string ItemNumber { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public int? ItemDescriptionTxtid { get; set; }

    public string? ItemDescriptionFlag { get; set; }

    public string? DrawingNo { get; set; }

    public string? RevesionNo { get; set; }

    public decimal? TareWeight { get; set; }

    public string? WeightUom { get; set; }

    public decimal? TareVolume { get; set; }

    public string? VolumeUom { get; set; }

    public string? OwnerType { get; set; }

    public string? PackingType { get; set; }

    public short? LowestLevelInStructure { get; set; }

    public short? LeadTime { get; set; }

    public short? TurnAroundTime { get; set; }

    public string? OperationListId { get; set; }

    public string? WarehouseId { get; set; }

    public string? StockLocation { get; set; }

    public string? StockPosition { get; set; }

    public string? StockingUnit { get; set; }

    public string? ItemAccountCode { get; set; }

    public decimal? CurrentBalance { get; set; }

    public string? MainLeasingPartner { get; set; }

    public decimal? CostPrice { get; set; }

    public DateTime? CostPriceDate { get; set; }

    public decimal? SalesPrice { get; set; }

    public DateTime? SalesPriceDate { get; set; }

    public string? ExtraItemDescription { get; set; }

    public string? AuditStamp { get; set; }
}
