using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpSwedelplanDeliveryPlanItem
{
    public int ProcessId { get; set; }

    public int RowId { get; set; }

    public string? SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? ConsigneeName { get; set; }

    public string? ItemNumber { get; set; }

    public string? ItemDescription { get; set; }

    public string? BuyerOrderNumber { get; set; }

    public DateTime? CalculationDate { get; set; }

    public int? LotNumber { get; set; }

    public int? OperationNumber { get; set; }
}
