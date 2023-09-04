using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwMoReservationPosition
{
    public string ComponentItem { get; set; } = null!;

    public string MfgOrder { get; set; } = null!;

    public string MfgOrderLine { get; set; } = null!;

    public decimal? ReservedQty { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public DateTime RequiredDate { get; set; }

    public string ReservationCode { get; set; } = null!;

    public string? ParentItem { get; set; }

    public int? ParentLot { get; set; }

    public DateTime? ParentReqdDate { get; set; }

    public string? Owner { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Status { get; set; }

    public string OperationNumber { get; set; } = null!;

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

    public int IdReservation { get; set; }

    public string? PositionIndicator { get; set; }

    public string? ComponentSortString { get; set; }
}
