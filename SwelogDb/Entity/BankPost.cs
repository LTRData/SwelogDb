using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class BankPost
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? SwiftBankNo { get; set; }

    public string? BankOffice { get; set; }

    public string? Address { get; set; }

    public string? PostalNo { get; set; }

    public string? Destination { get; set; }

    public string? AuditStamp { get; set; }

    public string? CountryCode { get; set; }
}
