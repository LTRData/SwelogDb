using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PaymentMode
{
    public string ModeOfPayment { get; set; } = null!;

    public string? ModeOfPaymentDesc { get; set; }

    public int? ModeOfPaymentDescTxtid { get; set; }

    public string? ModeOfPaymentDescFlag { get; set; }

    public string? Language { get; set; }

    public string? BankPostConnection { get; set; }

    public decimal? BankPostGiroNo { get; set; }

    public string? ForeignPayment { get; set; }

    public string? CurrencyCode { get; set; }

    public string? BankAccountNo { get; set; }

    public string? BankPostGiroCode { get; set; }

    public string? AuditStamp { get; set; }

    public string? IbanNr { get; set; }

    public string? SwiftAddress { get; set; }

    public string? SignId { get; set; }

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual ICollection<CustInvPayBatch> CustInvPayBatches { get; } = new List<CustInvPayBatch>();

    public virtual Language? LanguageNavigation { get; set; }

    public virtual ICollection<SuppInvHdrDummyFa> SuppInvHdrDummyFas { get; } = new List<SuppInvHdrDummyFa>();

    public virtual ICollection<SuppInvHdr> SuppInvHdrs { get; } = new List<SuppInvHdr>();

    public virtual ICollection<SuppInvPay> SuppInvPays { get; } = new List<SuppInvPay>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();
}
