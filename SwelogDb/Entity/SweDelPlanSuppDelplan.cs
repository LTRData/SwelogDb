using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SweDelPlanSuppDelplan
{
    public int IdSweDelPlanSuppDelplan { get; set; }

    public int? MessageId { get; set; }

    public int? DelforHeadId { get; set; }

    public int? DelplanNo { get; set; }

    public string? SupplierId { get; set; }

    public string? ItemNumber { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? Status { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public DateTime? AvailableDate { get; set; }

    public DateTime? DespatchDate { get; set; }

    public decimal? DespatchedQuantity { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }

    public string? BuyerOrderNumber { get; set; }
}
