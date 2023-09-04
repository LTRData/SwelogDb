using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ReservationHistory
{
    public string ItemNumber { get; set; } = null!;

    public string OrderNo { get; set; } = null!;

    public string OrderLine { get; set; } = null!;

    public decimal? ReservedQty { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public DateTime RequiredDate { get; set; }

    public string ReservationCode { get; set; } = null!;

    public string? ParentItem { get; set; }

    public int? LotNumber { get; set; }

    public DateTime? ParentReqdDate { get; set; }

    public string? Owner { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? Status { get; set; }

    public string OpnoDeladdrId { get; set; } = null!;

    public decimal? QuantityOfComponent { get; set; }

    public int? ItemNumberTxtid { get; set; }

    public string? PrintedFlag { get; set; }

    public short? PageNumber { get; set; }

    public string? SuggestionLinkId { get; set; }

    public decimal? ScrapPercentage { get; set; }

    public string? CustomerOrderNumber { get; set; }

    public string? DelplanOrderStatus { get; set; }

    public string? KanbanNo { get; set; }

    public string? PacklistNumber { get; set; }

    public string? DespatcherPlace { get; set; }

    public DateTime? AheadDate { get; set; }

    public string? StoreLocation { get; set; }

    public decimal? FixedUsage { get; set; }

    public int IdReservation { get; set; }

    public string? GoodsMarking { get; set; }

    public string? DpPartConsigment { get; set; }

    public DateTime? ArchiveDate { get; set; }
}
