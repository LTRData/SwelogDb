using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class IpJournalHeaderMp
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string Series { get; set; } = null!;

    public decimal VoucherNo { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? Text { get; set; }

    public string? AuditStamp { get; set; }

    public string? ActualSeries { get; set; }

    public decimal? ActualVoucherNo { get; set; }
}
