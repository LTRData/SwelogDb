using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvoiceDtl
{
    public string CompanyNo { get; set; } = null!;

    public decimal YearNo { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string InvoiceSeries { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public decimal LineNo { get; set; }

    public string? ItemNo { get; set; }

    public decimal? Quantity { get; set; }

    public string? UnitOfSale { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? DisPercentage { get; set; }

    public decimal? CostPrice { get; set; }

    public string? UnitOfStock { get; set; }

    public decimal? VatAmtFc { get; set; }

    public decimal? LineAmtFc { get; set; }

    public string? CountryGroupCode { get; set; }

    public string? CustomerAccountCode { get; set; }

    public string? ProductGroupCode { get; set; }

    public string? ProductAccountCode { get; set; }

    public string? CurrencyCode { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? OrderLineType { get; set; }

    public string? ItemDescription { get; set; }

    public int? ItemDescriptionTxtid { get; set; }

    public string? ItemDescriptionFlag { get; set; }

    public string? AuditStamp { get; set; }

    public string? VatCode { get; set; }

    public decimal? VatPercentage { get; set; }

    public short? PriceUnit { get; set; }

    public decimal? VatAmtBc { get; set; }

    public decimal? DisAmtFc { get; set; }

    public decimal? DisAmtBc { get; set; }

    public string? TransType { get; set; }

    public string? AdmnServiceLine { get; set; }

    public decimal? StockQuantity { get; set; }

    public decimal? SetupPrice { get; set; }

    public decimal? LineAmtBc { get; set; }

    public string? DeliveryNoteNumber { get; set; }

    public string? YourOrderNo { get; set; }

    public string? ConsigneeName { get; set; }

    public decimal? OrderHdrDisPercentage { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? ContainerNo { get; set; }

    public string? ContainerType { get; set; }

    public string? SigilNumber { get; set; }

    public decimal? WtInKg { get; set; }

    public decimal? VolInM3 { get; set; }

    public decimal? DisPercentage2 { get; set; }

    public decimal? DisAmtFc2 { get; set; }

    public string? GoodsMarking { get; set; }

    public string? GoodsMarkingHdr { get; set; }

    public string? BillNo { get; set; }

    public decimal? SellingPriceWithVat { get; set; }

    public decimal? LineAmtFcWithoutVat { get; set; }

    public string? OeTemplateId { get; set; }

    public decimal? SetupPriceWithVat { get; set; }

    public string? YourDeliveryNote { get; set; }

    public string? AlloyLineCreated { get; set; }

    public string? AlloyInvoiceSeries { get; set; }

    public decimal? AlloyInvoiceNo { get; set; }

    public string? UpdateIntrastat { get; set; }

    public string? ColorCode { get; set; }

    public int? EdiOrderLineNo { get; set; }

    public decimal? Area { get; set; }

    public string? AreaUom { get; set; }

    public decimal? SellingPricePerArea { get; set; }

    public decimal? SellingPricePerAreaWithVat { get; set; }

    public decimal? SellingPriceDc { get; set; }

    public decimal? SellingPriceWithVatDc { get; set; }

    public decimal? VatAmtFcDc { get; set; }

    public decimal? LineAmtFcDc { get; set; }

    public decimal? LineAmtFcWithoutVatDc { get; set; }

    public decimal? DisAmtFcDc { get; set; }

    public decimal? DisAmtFc2Dc { get; set; }

    public decimal? SetupPriceDc { get; set; }

    public decimal? SetupPriceWithVatDc { get; set; }

    public string? ScrapFlag { get; set; }

    public string? ConsigneeNameExtra { get; set; }

    public string? OrderCategory { get; set; }

    public string? DpPartConsignment { get; set; }

    public string? DoNotIncludeInKvartalsrapport { get; set; }

    public decimal? PurchasePrice { get; set; }

    public decimal? FreightPrice { get; set; }

    public decimal? TaxPrice { get; set; }

    public decimal? ConsPrice { get; set; }

    public decimal? VatPrice { get; set; }

    public decimal? ClearancePrice { get; set; }

    public decimal? ImportPrice { get; set; }

    public decimal? AlloySellingPriceFc { get; set; }

    public decimal? AlloySellingPriceBc { get; set; }

    public decimal? CalculatedPrice { get; set; }

    public decimal? ContributionMargin1 { get; set; }

    public decimal? ContributionMargin2 { get; set; }

    public decimal? ItemSellingPrice { get; set; }

    public DateTime? LastSellPriceChangeDate { get; set; }

    public string? VinNumber { get; set; }

    public string? CustNameForProforma { get; set; }

    public DateTime? YourDeliveryDate { get; set; }

    public string? DoNotUpdateQtyInInvStats { get; set; }

    public short? ItemPriceUnitNum { get; set; }

    public virtual Company CompanyNoNavigation { get; set; } = null!;

    public virtual CurrencyTable? CurrencyCodeNavigation { get; set; }

    public virtual CustInvoiceHdr CustInvoiceHdr { get; set; } = null!;

    public virtual UnitOfMeasure? UnitOfSaleNavigation { get; set; }

    public virtual UnitOfMeasure? UnitOfStockNavigation { get; set; }
}
