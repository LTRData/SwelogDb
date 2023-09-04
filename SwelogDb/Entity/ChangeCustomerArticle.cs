using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ChangeCustomerArticle
{
    public string ItemNumber { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string? CustomerArticleIdentity { get; set; }

    public string? CustomerUnitMeasure { get; set; }

    public decimal? RecalculateFactor { get; set; }

    public string? AuditStamp { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual UnitOfMeasure? CustomerUnitMeasureNavigation { get; set; }
}
