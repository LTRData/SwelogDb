using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class InvoiceStatisticsView
{
    public string CompNo { get; set; } = null!;

    public decimal YerNo { get; set; }

    public string InvoicType { get; set; } = null!;

    public string InvoicSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? OrderNumber { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? MarketCode { get; set; }

    public string? MarketDescription { get; set; }

    public string? TerritoryCode { get; set; }

    public string? TerritoryDescription { get; set; }

    public string? CustomerNo { get; set; }

    public string? CurrCode { get; set; }

    public decimal? OriginalRate { get; set; }

    public string? EuLabourCode { get; set; }

    public string? EuTransportModeCode { get; set; }

    public string? SalesmanCode { get; set; }

    public decimal? NetInvAmtFc { get; set; }

    public decimal? NetInvAmtBc { get; set; }

    public string? OrderLineType { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemNum { get; set; }

    public string? ItemDescription { get; set; }

    public string ProductGroup { get; set; } = null!;

    public string? ProductGroupDescription { get; set; }

    public decimal? Quantity { get; set; }

    public string? UnitOfSale { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? DisAmtFc { get; set; }

    public decimal? CostPrice { get; set; }

    public string? VatCode { get; set; }

    public decimal? SetupPrice { get; set; }

    public decimal? HdrDisAmtFc { get; set; }

    public decimal? BaseUnit { get; set; }

    public decimal? LineAmtFc { get; set; }

    public decimal? LineAmtBc { get; set; }

    public decimal? LineAmtFcBeforeDis { get; set; }

    public decimal? LineAmtBcBeforeDis { get; set; }

    public string? UnitOfStock { get; set; }

    public string? TransType { get; set; }

    public string? CustomerCategory { get; set; }

    public string? CategoryDescription { get; set; }

    public string? CustomerName { get; set; }

    public string? InvoiceJournalNo { get; set; }

    public string? SalesmanName { get; set; }

    public int? CurrPrecision { get; set; }

    public string? ScrapFlag { get; set; }

    public string AlloyFlag { get; set; } = null!;

    public decimal? AlloySellingPriceFc { get; set; }

    public decimal? AlloySellingPriceBc { get; set; }

    public int? PriceUnitNum { get; set; }

    public decimal? CalculatedPrice { get; set; }

    public decimal? ContributionMargin1 { get; set; }

    public decimal? ContributionMargin2 { get; set; }

    public decimal? ItemSellingPrice { get; set; }

    public DateTime? LastSellPriceChangeDate { get; set; }

    public string? Deleted { get; set; }

    public string? MailAddrCountryCode { get; set; }

    public string? DelAddrCountryCode { get; set; }

    public string? Emcs { get; set; }

    public short? ItemPriceUnitNum { get; set; }
}
