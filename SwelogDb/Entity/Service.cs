using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Service
{
    public string ServiceCode { get; set; } = null!;

    public string? ServiceDescription { get; set; }

    public int? ServiceDescriptionTxtid { get; set; }

    public string? SaleUnit { get; set; }

    public decimal? SellingPrice { get; set; }

    public short? PriceUnit { get; set; }

    public string? VatCode { get; set; }

    public decimal? CostPrice { get; set; }

    public string? AccountCode { get; set; }

    public decimal? InvAmntCurrPeriod { get; set; }

    public decimal? InvAmntCurrYear { get; set; }

    public decimal? InvAmntPreYear { get; set; }

    public decimal? InvQtyCurrPeriod { get; set; }

    public decimal? InvQtyCurrYear { get; set; }

    public decimal? InvQtyPreYear { get; set; }

    public string? AuditStamp { get; set; }

    public string? AutoCalculationFlag { get; set; }

    public decimal? AutoCalculationPercent { get; set; }

    public decimal? SellingPriceWithVat { get; set; }

    public string? StatisticsNumber { get; set; }

    public string? DoNotShowInInvoiceStats { get; set; }

    public virtual UnitOfMeasure? SaleUnitNavigation { get; set; }
}
