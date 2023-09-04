using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwOfferOpstr
{
    public string ItemNumber { get; set; } = null!;

    public string? OperationList { get; set; }

    public string? Structure { get; set; }

    public string? OrderTable { get; set; }

    public string? OrderType { get; set; }

    public string? OrderNumber { get; set; }
}
