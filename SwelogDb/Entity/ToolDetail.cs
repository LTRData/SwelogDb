using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToolDetail
{
    public string ToolNumber { get; set; } = null!;

    public short ToolSerialNumber { get; set; }

    public string? InventoryNo { get; set; }

    public string? StockLocation { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public decimal? PurchasePrice { get; set; }

    public short? YearRevalued { get; set; }

    public decimal? PresentValue { get; set; }

    public short? InspectionUsageInterval { get; set; }

    public decimal? ToolUsageInHours { get; set; }

    public DateTime? LastInspectionDate { get; set; }

    public string? ToolStatus { get; set; }

    public DateTime? ToolRejectionDate { get; set; }

    public DateTime? ExpectedDateOfReuse { get; set; }

    public string? Owner { get; set; }

    public decimal? QuantityLimitToToolCheck { get; set; }

    public decimal? TotalProductionByTool { get; set; }

    public DateTime? DateTestResultsSent { get; set; }

    public DateTime? DateTestResultsApproved { get; set; }

    public DateTime? DateLastUsed { get; set; }

    public decimal? QuantityThisUsage { get; set; }

    public string? AuditStamp { get; set; }

    public int? CurrentMfgLot { get; set; }

    public string? LastReactivationType { get; set; }

    public string? StockPosition { get; set; }

    public string? SupplierName { get; set; }

    public string? ImportStoreLocation { get; set; }

    public string? ImportDepartment { get; set; }

    public string? LastInspectionUserid { get; set; }

    public string? StockPosition2 { get; set; }

    public string? StockPosition3 { get; set; }

    public int? InspectionUsageIntervalDays { get; set; }

    public virtual ToolHeader ToolNumberNavigation { get; set; } = null!;

    public virtual ICollection<ToolReactivate> ToolReactivates { get; } = new List<ToolReactivate>();
}
