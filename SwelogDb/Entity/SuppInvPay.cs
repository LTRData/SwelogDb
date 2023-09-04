using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvPay
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string ArrivalSeries { get; set; } = null!;

    public decimal ArrivalNo { get; set; }

    public decimal LineNo { get; set; }

    public string? PayType { get; set; }

    public string? SuppNo { get; set; }

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

    public string? PrelPaid { get; set; }

    public string? TransferredToBank { get; set; }

    public string? Transferred { get; set; }

    public string? BankAccountNo { get; set; }

    public string? Urgent { get; set; }

    public string? BankName { get; set; }

    public string? BankOffice { get; set; }

    public string? SwiftBankNo { get; set; }

    public string? BankAddress { get; set; }

    public string? PostalNo { get; set; }

    public string? Destination { get; set; }

    public string? FreeReference { get; set; }

    public DateTime? LastGuardDate { get; set; }

    public string? AccountType { get; set; }

    public string? ChargeMode { get; set; }

    public string? PaymentForm { get; set; }

    public string? PaymentMethod { get; set; }

    public string? CodeOfBankOfSweden { get; set; }

    public string? SignalAdvance { get; set; }

    public string? CodeOfGuard { get; set; }

    public string? FreeHeadingCode { get; set; }

    public string? ForwardContractNo { get; set; }

    public string? AuthFromBankOfSweden { get; set; }

    public string? BankPostGiroCode { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? PayAmtFc { get; set; }

    public DateTime? PrelPayDate { get; set; }

    public string? BankPostConnection { get; set; }

    public string? ForeignPayment { get; set; }

    public string? PayModeBankAccNo { get; set; }

    public string? OcrNo { get; set; }

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual PaymentMode? PayModeNavigation { get; set; }

    public virtual ICollection<SuppInvPayJournal> SuppInvPayJournals { get; } = new List<SuppInvPayJournal>();

    public virtual Supplier? SuppNoNavigation { get; set; }
}
