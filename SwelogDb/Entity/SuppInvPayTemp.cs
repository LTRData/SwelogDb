using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvPayTemp
{
    public string CompanyNo { get; set; } = null!;

    public string InvoiceType { get; set; } = null!;

    public string ArrivalSeries { get; set; } = null!;

    public decimal ArrivalNo { get; set; }

    public decimal LineNo { get; set; }

    public string? SuppNo { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? PayAmtBc { get; set; }

    public decimal? DisAmtFc { get; set; }

    public decimal? DisAmtBc { get; set; }

    public decimal? DebtAmtFc { get; set; }

    public decimal? DebtAmtBc { get; set; }

    public decimal? RateDiffBc { get; set; }

    public DateTime? PaymentDate { get; set; }

    public DateTime? DueDisDate { get; set; }

    public string? PayMode { get; set; }

    public string? PrelPaid { get; set; }

    public string? TransferredToBank { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? PayAmtFc { get; set; }

    public string? ForeignPayment { get; set; }

    public decimal? DiscAmtTotFc { get; set; }

    public decimal? DiscAmtTotBc { get; set; }

    public decimal? PaidAmtTotFc { get; set; }

    public decimal? PaidAmtTotBc { get; set; }

    public decimal? OriginalRate { get; set; }

    public decimal? AccountingRate { get; set; }

    public decimal? BadDebtFc { get; set; }

    public string? DefPaid { get; set; }

    public decimal? InvAmountFc { get; set; }

    public decimal? InvAmountBc { get; set; }

    public string? WorkstationId { get; set; }
}
