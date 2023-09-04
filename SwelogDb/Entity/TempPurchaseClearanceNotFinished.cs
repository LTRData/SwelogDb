﻿using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class TempPurchaseClearanceNotFinished
{
    public string OrderType { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public short OrderLineNumber { get; set; }

    public short OrderLineNumberSub { get; set; }

    public DateTime PlannedDeliveryDate { get; set; }

    public string DeliveryAddressId { get; set; } = null!;

    public string? ItemNumber { get; set; }

    public string? Description { get; set; }

    public decimal? OrderQuantity { get; set; }

    public decimal? ActualDeliveredQuantity { get; set; }

    public DateTime? LastDeliveredDate { get; set; }

    public string? DeliveryStatus { get; set; }

    public string? DeleteRow { get; set; }
}
