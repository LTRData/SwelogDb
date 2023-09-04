using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SuppInvHdrDummyGn
{
    public int RecNo { get; set; }

    public string? CompanyNo { get; set; }

    public decimal? YearNo { get; set; }

    public string? InvoiceType { get; set; }

    public string? ArrivalSeries { get; set; }

    public decimal? ArrivalNo { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? SupplierNo { get; set; }

    public string? InvoiceNo { get; set; }

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

    public string? Authorised { get; set; }

    public string? Responsible { get; set; }

    public string? PrelPaid { get; set; }

    public string? FullyPaid { get; set; }

    public string? PayMode { get; set; }

    public string? Transferred { get; set; }

    public string? Active { get; set; }

    public string? DefCoded { get; set; }

    public string? AccPayAccount { get; set; }

    public string? VatAccount { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? Av3HdrYearNo { get; set; }

    public decimal? Av3HdrRecNo { get; set; }

    public decimal? VatPercentage { get; set; }

    public string? PaymentTermSuppInvoice { get; set; }

    public string? DeliveryTermsCode { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? OcrNo { get; set; }

    public string? InvoiceReference { get; set; }

    public string? VatCode { get; set; }

    public string? VatCode2 { get; set; }

    public string? VatCode3 { get; set; }

    public string? VatCode4 { get; set; }

    public decimal? VatPercentage2 { get; set; }

    public decimal? VatPercentage3 { get; set; }

    public decimal? VatPercentage4 { get; set; }

    public decimal? VatAmountFc2 { get; set; }

    public decimal? VatAmountFc3 { get; set; }

    public decimal? VatAmountFc4 { get; set; }

    public decimal? VatAmountBc2 { get; set; }

    public decimal? VatAmountBc3 { get; set; }

    public decimal? VatAmountBc4 { get; set; }

    public decimal? VatBaseFc { get; set; }

    public decimal? VatBaseFc2 { get; set; }

    public decimal? VatBaseFc3 { get; set; }

    public decimal? VatBaseFc4 { get; set; }

    public string? BankgiroNo { get; set; }

    public string? PostgiroNo { get; set; }

    public string? PersonNo { get; set; }

    public decimal? OtherCostsFc { get; set; }

    public decimal? OtherCostsBc { get; set; }

    public string? BankAccountNo { get; set; }

    public string? ReadyToTransfer { get; set; }

    public string? AttestCode { get; set; }

    public string? Preattest1 { get; set; }

    public string? Preattest2 { get; set; }

    public string? FinalAttest { get; set; }

    public string? XmlFilePath { get; set; }

    public string? PdfFilePath { get; set; }

    public string? VendorId3 { get; set; }

    public string? FilePath { get; set; }

    public string? VatRegistrationNumber { get; set; }

    public string? VatRegistrationNumber2 { get; set; }

    public string? SuppBankAccountForeignPay { get; set; }

    public string? MultipleSuppFlag { get; set; }

    public virtual ICollection<SuppInvJournalDummyGn> SuppInvJournalDummyGns { get; } = new List<SuppInvJournalDummyGn>();
}
