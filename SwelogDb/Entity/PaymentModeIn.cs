using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PaymentModeIn
{
    public string ModeOfPayment { get; set; } = null!;

    public string? ModeOfPaymentDesc { get; set; }

    public string? Code { get; set; }

    public string? CurrencyCode { get; set; }

    public string? PaymentType { get; set; }

    public string? BankgiroNo { get; set; }

    public string? PostgiroNo { get; set; }

    public string? IbanNr { get; set; }

    public string? SwiftAddress { get; set; }

    public string? ServiceType { get; set; }

    public string? ServiceNo { get; set; }

    public string? OcrKidNoModulusType { get; set; }

    public byte? NoOfDigitsForOcrNo { get; set; }

    public string? AccountNo { get; set; }

    public string? VatRegNo { get; set; }

    public string? AuditStamp { get; set; }

    public string? FactoringAccountNo { get; set; }

    public string? VatRegNoForeign { get; set; }

    public virtual ICollection<CustInvHdr> CustInvHdrs { get; } = new List<CustInvHdr>();

    public virtual ICollection<CustInvPay> CustInvPays { get; } = new List<CustInvPay>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<PaymentModeInText> PaymentModeInTexts { get; } = new List<PaymentModeInText>();
}
