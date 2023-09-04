using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpImportQrCodeGoodsentry
{
    public int IdTmpImportQrCodeGoodsentry { get; set; }

    public string? QrCode { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public string? OrderLineType { get; set; }

    public int? IdPurchaseOrderDtl { get; set; }

    public string ItemNumber { get; set; } = null!;

    public decimal? TotalRecvdQty { get; set; }

    public string? PalletNo { get; set; }

    public decimal? PalletRecvdQty { get; set; }

    public string? CertificateDesc { get; set; }

    public string? GoodsentryNo { get; set; }

    public short? RowNo { get; set; }

    public string? PalletPrinted { get; set; }
}
