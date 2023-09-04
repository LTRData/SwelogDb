using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwGoodsentryIntrastat
{
    public string IntrastatCode { get; set; } = null!;

    public string? EuCode { get; set; }

    public string? TariffCode { get; set; }

    public string? TransactionType { get; set; }

    public string? TransportMode { get; set; }

    public DateTime ArrivalDate { get; set; }

    public string GoodsEntryNo { get; set; } = null!;

    public decimal? NetWeight { get; set; }

    public decimal? StatValue { get; set; }

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public string? AuditStamp { get; set; }
}
