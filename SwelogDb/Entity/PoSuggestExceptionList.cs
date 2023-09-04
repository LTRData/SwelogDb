using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PoSuggestExceptionList
{
    public short ExceptionNo { get; set; }

    public string? ExceptionCode { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? NeedDate { get; set; }

    public decimal? Quantity { get; set; }

    public string? AuditStamp { get; set; }

    public string? ItemDescription { get; set; }

    public int? DueDateCcyywwd { get; set; }

    public int? NeedDateCcyywwd { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? DeliveryDateCcyywwd { get; set; }
}
