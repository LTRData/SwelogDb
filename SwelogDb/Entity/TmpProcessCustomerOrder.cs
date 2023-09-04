using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TmpProcessCustomerOrder
{
    public int ProcessId { get; set; }

    public int RowNumber { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public string? ItemNumber { get; set; }

    public string? DeliveryAddressId { get; set; }

    public decimal? DeliveredQuantity { get; set; }

    public string? CustomersItemNumber { get; set; }

    public string? CustomersOrderNumber { get; set; }

    public string? CustomerId { get; set; }

    public DateTime? PlannedDeliveryDate { get; set; }

    public string? UnitOfSale { get; set; }

    public decimal? OrderQuantity { get; set; }

    public string? Userid { get; set; }

    public string? Workstation { get; set; }

    public string? AuditStamp { get; set; }

    public bool? Picklisted { get; set; }

    public bool? Selected { get; set; }

    public string? PicklistNumber { get; set; }
}
