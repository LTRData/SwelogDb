using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustomerArticle
{
    public string ItemNumber { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string? CustomerArticleIdentity { get; set; }

    public string? CustomerUnitMeasure { get; set; }

    public decimal? RecalculateFactor { get; set; }

    public string? AuditStamp { get; set; }

    public string? CustomerArticleIdentityDesc { get; set; }

    public int? LeadTimeInDays { get; set; }

    public string? PackMtrlFlag { get; set; }

    public string? PreferedYn { get; set; }

    public string? OnlabelYn { get; set; }

    public decimal? MinDelQty { get; set; }

    public string? DrawingNo { get; set; }

    public string? RevisionNo { get; set; }

    public string? SpecialLabelYn { get; set; }

    public string? SellingPriceExchangeCurrency { get; set; }

    public decimal? SellingPriceExchangeRate { get; set; }

    public DateTime? SellingPriceExchangeRateDate { get; set; }

    public decimal? SellingPriceBc { get; set; }

    public string? DeliveryAddressId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual CustomerDeliveryAddress? CustomerDeliveryAddress { get; set; }

    public virtual UnitOfMeasure? CustomerUnitMeasureNavigation { get; set; }

    public virtual Item ItemNumberNavigation { get; set; } = null!;
}
