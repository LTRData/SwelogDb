using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwViaForwardLabel
{
    public string MessageId { get; set; } = null!;

    public string DelnoteLineId { get; set; } = null!;

    public string Serialno { get; set; } = null!;

    public int Quantity { get; set; }
}
