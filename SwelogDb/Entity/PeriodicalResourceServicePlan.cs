using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class PeriodicalResourceServicePlan
{
    public string OperationList { get; set; } = null!;

    public short OperationNumber { get; set; }

    public string Yyyyww { get; set; } = null!;

    public string? ResourceServiceOrder { get; set; }

    public string? Resource { get; set; }

    public string? OrderItem { get; set; }

    public int? OrderLot { get; set; }

    public int? OrderLotUpto { get; set; }

    public int? OrderedDayOfWeek { get; set; }
}
