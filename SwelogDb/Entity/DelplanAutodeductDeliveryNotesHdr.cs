using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DelplanAutodeductDeliveryNotesHdr
{
    public string? ItemNumber { get; set; }

    public string? CustomerId { get; set; }

    public string? DeladdrId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? QuantityDeducted { get; set; }

    public int? CurrentDelplanDtlId { get; set; }

    public decimal? CurrentDelplanDtlQty { get; set; }

    public int IdDelplanAutodeductDeliveryNotesHdr { get; set; }
}
