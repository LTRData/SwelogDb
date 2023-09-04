using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ErrorLogFa
{
    public string CompanyNo { get; set; } = null!;

    public string InvoiceType { get; set; } = null!;

    public string ArrivalSeries { get; set; } = null!;

    public decimal ArrivalNo { get; set; }

    public string? ErrorText { get; set; }

    public string? ErrorTextDetail { get; set; }

    public DateTime? LogDate { get; set; }

    public string? Status { get; set; }

    public string? AuditStamp { get; set; }
}
