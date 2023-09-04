using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvPay
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public decimal LineNo { get; set; }

    public string? PayType { get; set; }

    public string? CustomerNo { get; set; }

    public string? BatchNo { get; set; }

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

    public short? DueDays { get; set; }

    public string? CreateIntInv { get; set; }

    public string? IntInvCreated { get; set; }

    public string? PrintIntInv { get; set; }

    public decimal? IntInvExchRate { get; set; }

    public decimal? IntAmtFc { get; set; }

    public decimal? IntAmtBc { get; set; }

    public string? PrelPaid { get; set; }

    public string? Transferred { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? PayAmtFc { get; set; }

    public decimal? BalAmtForFullyPaidFc { get; set; }

    public decimal? BalAmtForFullyPaidBc { get; set; }

    public string? IntInvoiceSeries { get; set; }

    public decimal? IntInvoiceNo { get; set; }

    public string? CustomerToFactor { get; set; }

    public decimal? AdvanceVatAmtFc { get; set; }

    public decimal? AdvanceVatAmtBc { get; set; }

    public decimal? LastIntAmtFc { get; set; }

    public decimal? LastIntAmtBc { get; set; }

    public decimal? AdvanceRoundingAmtFc { get; set; }

    public decimal? AdvanceRoundingAmtBc { get; set; }

    public string? VatCode { get; set; }

    public string? VatCode2 { get; set; }

    public string? VatCode3 { get; set; }

    public string? VatCode4 { get; set; }

    public decimal? AdvanceVatAmtFc2 { get; set; }

    public decimal? AdvanceVatAmtFc3 { get; set; }

    public decimal? AdvanceVatAmtFc4 { get; set; }

    public decimal? AdvanceVatAmtBc2 { get; set; }

    public decimal? AdvanceVatAmtBc3 { get; set; }

    public decimal? AdvanceVatAmtBc4 { get; set; }

    public decimal? VatPercentage { get; set; }

    public decimal? VatPercentage2 { get; set; }

    public decimal? VatPercentage3 { get; set; }

    public decimal? VatPercentage4 { get; set; }

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual ICollection<CustInvPayJournal> CustInvPayJournals { get; } = new List<CustInvPayJournal>();

    public virtual Customer? CustomerNoNavigation { get; set; }

    public virtual PaymentModeIn? PayModeNavigation { get; set; }
}
