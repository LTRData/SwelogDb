using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvHdr
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public string? CustomerNo { get; set; }

    public string? InvoiceRefSeries { get; set; }

    public decimal? InvoiceRefNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? DisDate { get; set; }

    public DateTime? VoucherDate { get; set; }

    public decimal? DisPercentage { get; set; }

    public decimal? DiscountDays { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? OriginalRate { get; set; }

    public decimal? AccountingRate { get; set; }

    public decimal? InvAmountFc { get; set; }

    public decimal? InvAmountBc { get; set; }

    public decimal? VatAmountFc { get; set; }

    public decimal? VatAmountBc { get; set; }

    public decimal? BadDebtFc { get; set; }

    public decimal? BadDebtBc { get; set; }

    public decimal? IntAmountFc { get; set; }

    public decimal? IntAmountBc { get; set; }

    public decimal? RevalnRateDiffAmtBc { get; set; }

    public decimal? DelayIntPerc { get; set; }

    public string? Text { get; set; }

    public string? Blocked { get; set; }

    public string? FullyPaid { get; set; }

    public string? PayMode { get; set; }

    public string? Transferred { get; set; }

    public string? Active { get; set; }

    public int? DemandNo { get; set; }

    public DateTime? DemandDate { get; set; }

    public string? AccRecAccount { get; set; }

    public string? VatAccount { get; set; }

    public string? AuditStamp { get; set; }

    public string? CreateIntInv { get; set; }

    public decimal? VatPercentage { get; set; }

    public decimal? ServiceChargePercentage { get; set; }

    public decimal? ServiceChargeAmtBc { get; set; }

    public decimal? BlockAmountPercentage { get; set; }

    public decimal? BlockedAmtBc { get; set; }

    public string? BlockedAmtPaidFlag { get; set; }

    public DateTime? BlockedAmtPaidDate { get; set; }

    public string? SettlementFlag { get; set; }

    public string? DebtCollectorFlag { get; set; }

    public string? SheriffFlag { get; set; }

    public string? CustomerToFactor { get; set; }

    public string? Printed { get; set; }

    public decimal? RoundingAmtFc { get; set; }

    public decimal? RoundingAmtBc { get; set; }

    public decimal? AdminAmtFc { get; set; }

    public decimal? AdminAmtBc { get; set; }

    public string? StatusCode { get; set; }

    public string? YourReference { get; set; }

    public string? YourInvoiceNo { get; set; }

    public string? OcrNo { get; set; }

    public decimal? RotAmtBc { get; set; }

    public string? RotCreatedFlag { get; set; }

    public int? RotNo { get; set; }

    public DateTime? RotCreatedDate { get; set; }

    public decimal? AdmnChargeForReminderFc { get; set; }

    public decimal? AdmnChargeForReminderBc { get; set; }

    public decimal? AccruedIntForReminderFc { get; set; }

    public decimal? AccruedIntForReminderBc { get; set; }

    public DateTime? AccruedIntDateForReminder { get; set; }

    public decimal? AdmnChargeForDebtCollectorFc { get; set; }

    public decimal? AdmnChargeForDebtCollectorBc { get; set; }

    public decimal? AccruedIntForDebtCollectorFc { get; set; }

    public decimal? AccruedIntForDebtCollectorBc { get; set; }

    public DateTime? AccruedIntDateForDebtCollector { get; set; }

    public decimal? ApplcnFeeForSheriffFc { get; set; }

    public decimal? ApplcnFeeForSheriffBc { get; set; }

    public decimal? RepresentativeFeeForSheriffFc { get; set; }

    public decimal? RepresentativeFeeForSheriffBc { get; set; }

    public decimal? AccruedIntForSheriffFc { get; set; }

    public decimal? AccruedIntForSheriffBc { get; set; }

    public DateTime? AccruedIntDateForSheriff { get; set; }

    public string? ExtraText { get; set; }

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual ICollection<CustInvHdrDemandDate> CustInvHdrDemandDates { get; } = new List<CustInvHdrDemandDate>();

    public virtual ICollection<CustInvJournal> CustInvJournals { get; } = new List<CustInvJournal>();

    public virtual Customer? CustomerNoNavigation { get; set; }

    public virtual PaymentModeIn? PayModeNavigation { get; set; }
}
