using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ContractOrderRelation
{
    public string CustomerNumber { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public string DeliveryAddressId { get; set; } = null!;

    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }
}
