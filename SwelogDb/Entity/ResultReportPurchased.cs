using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResultReportPurchased
{
    public short SerialNo { get; set; }

    public string? ItemNumber { get; set; }

    public string? SupplierId { get; set; }

    public string? SupplierDeliveryAddressId { get; set; }

    public string? PurchaseOrder { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? Code { get; set; }

    public DateTime? NewReadyDate { get; set; }

    public string? TransferFlag { get; set; }

    public DateTime? TransferDate { get; set; }
}
