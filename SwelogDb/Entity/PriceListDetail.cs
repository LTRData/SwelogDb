using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PriceListDetail
{
    public string PriceListId { get; set; } = null!;

    public string CurrencyCode { get; set; } = null!;

    public DateTime PriceListStartDate { get; set; }

    public string ItemNumber { get; set; } = null!;

    public decimal PriceListQuantityLimit { get; set; }

    public string? SaleUnitOfMeasure { get; set; }

    public decimal? SellingPrice { get; set; }

    public short? PriceUnit { get; set; }

    public decimal? Discount { get; set; }

    public string? AuditStamp { get; set; }

    public decimal? SetupPrice { get; set; }

    public string? Recalculate { get; set; }

    public string? CustomerDiscount { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? MinDelQty { get; set; }

    public string? ItemDescription { get; set; }

    public DateTime? EventDate { get; set; }

    public decimal? SellingPriceExchangeRate { get; set; }

    public DateTime? SellingPriceExchangeRateDate { get; set; }

    public virtual Item ItemNumberNavigation { get; set; } = null!;

    public virtual ICollection<PriceListDetailAlloy> PriceListDetailAlloys { get; } = new List<PriceListDetailAlloy>();

    public virtual PriceListHdr PriceListHdr { get; set; } = null!;

    public virtual UnitOfMeasure? SaleUnitOfMeasureNavigation { get; set; }
}
