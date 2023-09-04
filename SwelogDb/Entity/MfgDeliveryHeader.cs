using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgDeliveryHeader
{
    public int IdMfgDeliveryHeader { get; set; }

    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public DateTime DeliveryDatetime { get; set; }

    public decimal? DeliveryQuantity { get; set; }

    public string? InspectionId { get; set; }

    public string? InspectionStatus { get; set; }

    public decimal? InspectedQuantity { get; set; }

    public decimal? ApprovedQuantity { get; set; }

    public string? AuditStamp { get; set; }

    public int? OperationNumber { get; set; }

    public string? DeliveryType { get; set; }
}
