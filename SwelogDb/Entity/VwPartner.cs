using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwPartner
{
    public string PartnerType { get; set; } = null!;

    public string? PartnerId { get; set; }

    public string? PartnerKey { get; set; }

    public string? PartnerName { get; set; }

    public int? PertnerNameTxtid { get; set; }

    public int? MailingAddressNo { get; set; }

    public int? ElectronicAddress { get; set; }

    public string? OurReference { get; set; }

    public string? PartnerReference { get; set; }

    public string? GoodsReference { get; set; }

    public string? InvoiceReference { get; set; }

    public string? LanguageCode { get; set; }

    public string? CurrencyCode { get; set; }

    public string? EuCountryCode { get; set; }

    public string? EuLabourCode { get; set; }

    public string? VatRegistrationNumber { get; set; }
}
