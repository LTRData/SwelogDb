using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ServiceCharge
{
    public string ServiceChargeId { get; set; } = null!;

    public string? ServiceChargeDesc { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? ServiceChargeLimitingValue { get; set; }

    public decimal? ServiceChargeAmount { get; set; }

    public short? ServiceChargeMethod { get; set; }

    public string? AuditStamp { get; set; }

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }
}
