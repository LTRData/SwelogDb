using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwPurchaseOrderDtl
{
    public int IdPurchaseOrderDtl { get; set; }

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public string? PartnerId { get; set; }

    public string? EuTransportModeCode { get; set; }

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public string? OrderLineType { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public string? MfgOrder { get; set; }

    public string? MfgItem { get; set; }

    public short? MfgLot { get; set; }

    public short? MfgOperation { get; set; }

    public decimal? OrderQuantity { get; set; }

    public decimal? QuantityGenerated { get; set; }

    public decimal? DeliveredStockUnits { get; set; }

    public string? UnitOfStock { get; set; }

    public decimal? StockReceivedQty { get; set; }

    public string SkipStockhandlingYn { get; set; } = null!;

    public string? IsPalletLabelYn { get; set; }

    public string PiaArrivalYn { get; set; } = null!;

    public string PalletStatus { get; set; } = null!;

    public string PalletOwnerType { get; set; } = null!;

    public string? PalletOwner { get; set; }

    public string? FixedLocation { get; set; }

    public decimal? PriceBcAfterDisc { get; set; }

    public decimal? PriceBcAfterDiscExclAlloy { get; set; }

    public decimal? PriceFcAfterDiscExclAlloy { get; set; }

    public decimal? AlloySurchargeFc { get; set; }

    public short? PriceUnit { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CertificateRequiredYn { get; set; }

    public string? ArrivalNote { get; set; }

    public string? FnGoodsentryInspectionYn { get; set; }
}
