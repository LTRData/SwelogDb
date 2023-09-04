using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpSwedelplanDeliveryPlanDetail
{
    public int ProcessId { get; set; }

    public int RowId { get; set; }

    public string? ItemNumber { get; set; }

    public string? BuyerOrderNumber { get; set; }

    public decimal? Quantity { get; set; }

    public int? Status { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public DateTime? AvailableDate { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public DateTime? DespatchDate { get; set; }

    public decimal? DespatchedQuantity { get; set; }
}
