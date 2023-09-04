﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class JournalHeader
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public decimal RecNo { get; set; }

    public decimal JournalType { get; set; }

    public string? Series { get; set; }

    public decimal? VoucherNo { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? Description1 { get; set; }

    public string? Cancelled { get; set; }

    public string? BatchSeries { get; set; }

    public decimal? BatchNo { get; set; }

    public string? AutoGenerate { get; set; }

    public string? ClosingEntry { get; set; }

    public string? ClosingRefNo { get; set; }

    public string? AutoVouchRefNo { get; set; }

    public string? AuditStamp { get; set; }

    public string? Subsystem { get; set; }

    public string? CurrencyCode { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual FinancialYear FinancialYear { get; set; } = null!;

    public virtual ICollection<JournalDetail> JournalDetails { get; } = new List<JournalDetail>();
}
