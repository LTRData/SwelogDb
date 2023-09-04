using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ErrorLogSuppInvHdrDummyGn
{
    public int RecNo { get; set; }

    public int? HdrRecNo { get; set; }

    public string? CompanyNo { get; set; }

    public string? InvoiceType { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }

    public string? ErrorText { get; set; }

    public string? ErrorTextDetail { get; set; }

    public DateTime? LogDate { get; set; }

    public string? Status { get; set; }

    public string? AuditStamp { get; set; }

    public string? XmlFilePath { get; set; }

    public string? PdfFilePath { get; set; }
}
