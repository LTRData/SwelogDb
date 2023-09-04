using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpAtpDetail
{
    public int? ProcessId { get; set; }

    public string? RowLevel { get; set; }

    public string? TransType { get; set; }

    public string? ItemNumber { get; set; }

    public string? OrderNo { get; set; }

    public string? RowKey { get; set; }

    public string? CustomerOrSupplier { get; set; }

    public string? PartnerName { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? SimulatedDate { get; set; }

    public int? DateIncrement { get; set; }

    public string? OrderStatus { get; set; }
}
