using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwSupplierConsignation
{
    public int SerialNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? SupplierId { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public short? OrderLineNumberSub { get; set; }

    public string? GoodsentryNo { get; set; }

    public string? InspectionCertificate { get; set; }

    public decimal? TotalQuantity { get; set; }

    public string? GeneratedSuppliersPalletNo { get; set; }

    public string? InternalPalletNo { get; set; }

    public decimal? PalletQuantity { get; set; }

    public string? CurrentStatus { get; set; }

    public int? NumberOfPallets { get; set; }

    public decimal? PalletQuantityInCs { get; set; }

    public string? UomFormat { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Datemask { get; set; }

    public decimal? GoodsrecQuantityInCs { get; set; }

    public decimal? MovedQtyForPallet { get; set; }

    public decimal? MovedQtyForGoodsrec { get; set; }
}
