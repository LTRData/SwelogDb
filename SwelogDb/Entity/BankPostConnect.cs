using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BankPostConnect
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? AuditStamp { get; set; }

    public string? ServiceType { get; set; }

    public string? ServiceNo { get; set; }

    public string? IbanNr { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string CompanyNo { get; set; } = null!;
}
