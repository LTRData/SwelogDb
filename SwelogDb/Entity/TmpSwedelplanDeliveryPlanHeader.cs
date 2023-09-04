using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpSwedelplanDeliveryPlanHeader
{
    public int ProcessId { get; set; }

    public int RowId { get; set; }

    public int? DelplanNo { get; set; }

    public string? SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? BuyerOrderNumber { get; set; }

    public bool? OperationPlan { get; set; }
}
