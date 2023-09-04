using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class MfgOrderPicklistMaterial
{
    public int PicklistNumber { get; set; }

    public int OperationNumber { get; set; }

    public int IdReservation { get; set; }

    public string? MfgOrderLine { get; set; }

    public string? ItemNumber { get; set; }

    public decimal? PicklistQuantity { get; set; }
}
