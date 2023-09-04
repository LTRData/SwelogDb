using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvHdrXmlLog
{
    public int RecNo { get; set; }

    public DateTime? LogTimestamp { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }

    public string? SupplierNo { get; set; }

    public string? ErrorText { get; set; }

    public string? XmlFilePath { get; set; }

    public string? Status { get; set; }
}
