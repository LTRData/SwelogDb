using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class UserDefinedCharge
{
    public string UserServiceChargeId { get; set; } = null!;

    public string CustomerCategory { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string? ChargeDescription { get; set; }

    public string? ChargeType { get; set; }

    public decimal? ChargePercentage { get; set; }

    public decimal? ChargeAmount { get; set; }

    public short? ServiceChargeMethod { get; set; }

    public string? TaxIndicator { get; set; }

    public string? TaxCode { get; set; }

    public string? AuditStamp { get; set; }

    public virtual CustomerCategory CustomerCategoryNavigation { get; set; } = null!;

    public virtual Tax? TaxCodeNavigation { get; set; }
}
