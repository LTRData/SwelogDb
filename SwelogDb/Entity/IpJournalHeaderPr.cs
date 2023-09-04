using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class IpJournalHeaderPr
{
    public int RecNo { get; set; }

    public string? CompanyNo { get; set; }

    public decimal? YearNo { get; set; }

    public string? Series { get; set; }

    public decimal? VoucherNo { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? Text { get; set; }

    public string? AuditStamp { get; set; }

    public string? ActualSeries { get; set; }

    public decimal? ActualVoucherNo { get; set; }

    public decimal? Av3HeadRecNo { get; set; }

    public string? AutoVoucherId { get; set; }
}
