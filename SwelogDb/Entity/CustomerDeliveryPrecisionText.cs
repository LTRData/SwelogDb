using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerDeliveryPrecisionText
{
    public int RecNo { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int OrderLineNumber { get; set; }

    public string ItemNumber { get; set; } = null!;

    public DateTime PlannedDeliveryDate { get; set; }

    public string LineText { get; set; } = null!;

    public string? AuditStamp { get; set; }
}
