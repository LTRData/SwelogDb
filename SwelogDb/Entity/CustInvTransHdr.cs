using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvTransHdr
{
    public string CompanyNo { get; set; } = null!;

    public decimal? YearNo { get; set; }

    public string TransType { get; set; } = null!;

    public string TransSeries { get; set; } = null!;

    public decimal TransNo { get; set; }

    public DateTime? TransDate { get; set; }

    public string? Description1 { get; set; }

    public string? RefInvoiceNo { get; set; }

    public string? CustomerNo { get; set; }

    public string? PayMode { get; set; }

    public string? RefTransSeries { get; set; }

    public decimal? RefTransNo { get; set; }

    public string? Active { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? AmountFc { get; set; }

    public decimal? AmountBc { get; set; }

    public decimal? RateDiffBc { get; set; }

    public string? Transferred { get; set; }

    public string? AuditStamp { get; set; }

    public DateTime? InactiveDate { get; set; }

    public string? FullyPaid { get; set; }

    public virtual ICollection<CustInvTransJournal> CustInvTransJournals { get; } = new List<CustInvTransJournal>();
}
