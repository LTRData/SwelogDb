using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MosResultReportManufactured
{
    public int? SerialNo { get; set; }

    public string? OrderNumber { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public decimal? OrderQuantity { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? ReadyDate { get; set; }

    public string? Code { get; set; }

    public DateTime? NewReadyDate { get; set; }

    public string? Status { get; set; }

    public string? TransferFlag { get; set; }

    public DateTime? TransferDate { get; set; }

    public decimal? DeliveryQuantity { get; set; }

    public string? ItemDescription { get; set; }

    public int? StartDateYyyywwd { get; set; }

    public int? ReadyDateYyyywwd { get; set; }

    public int? NewReadyDateYyyywwd { get; set; }

    public string? OrderLine { get; set; }

    public string? FirstDemandOnThatDay { get; set; }

    public decimal? QuantityPerPallet { get; set; }

    public decimal? ExpiringBalance { get; set; }

    public int? ExpiringDays { get; set; }

    public string? Comments { get; set; }
}
