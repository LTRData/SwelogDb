using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class OperationQuality
{
    public string Id { get; set; } = null!;

    public string SupplierId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public short? OperationNumber { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? WrongQtyDlv { get; set; }

    public string? WrongTimeDlv { get; set; }

    public string? RejectionInd { get; set; }

    public string? ReclamationInd { get; set; }

    public string? PartDeliveryInd { get; set; }

    public string? AuditStamp { get; set; }
}
