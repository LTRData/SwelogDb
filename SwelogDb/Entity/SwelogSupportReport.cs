using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SwelogSupportReport
{
    public int SerialNumber { get; set; }

    public string? ReportId { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public byte? Category { get; set; }

    public byte? Urgency { get; set; }

    public string? ReportedByUserid { get; set; }

    public string? ReportByName { get; set; }

    public DateTime? ReportedDatetime { get; set; }

    public string? ModuleName { get; set; }

    public string? MenuDescription { get; set; }

    public string? ReportText { get; set; }

    public string? Attachments { get; set; }

    public byte? Status { get; set; }

    public string? HandledBy { get; set; }

    public DateTime? HandlingStartDate { get; set; }

    public DateTime? HandlingEndDate { get; set; }

    public string? Answer1 { get; set; }

    public string? Answer2 { get; set; }

    public string? Answer3 { get; set; }

    public string? Answer4 { get; set; }

    public string? TelefonNo { get; set; }
}
