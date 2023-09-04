using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PriceListHdr
{
    public string PriceListId { get; set; } = null!;

    public string? PriceListDescription { get; set; }

    public int? PriceListDescriptionTxtid { get; set; }

    public string? PriceListDescriptionFlag { get; set; }

    public string? CustomerCategory { get; set; }

    public string? CustomerId { get; set; }

    public string? MarketCode { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public DateTime PriceListStartDate { get; set; }

    public DateTime? PriceListEndDate { get; set; }

    public string? AuditStamp { get; set; }

    public string? ContractNo { get; set; }

    public decimal? MaterialOverheadPercent { get; set; }

    public string? CampaignFlag { get; set; }

    public virtual CurrencyTable CurrencyCodeNavigation { get; set; } = null!;

    public virtual CustomerCategory? CustomerCategoryNavigation { get; set; }

    public virtual Market? MarketCodeNavigation { get; set; }

    public virtual ICollection<PriceListDetail> PriceListDetails { get; } = new List<PriceListDetail>();
}
