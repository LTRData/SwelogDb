using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Ordernumber2InvoiceTmp
{
    public string OrderNumber2 { get; set; } = null!;

    public decimal InvoiceNo { get; set; }

    public DateTime InvoiceDate { get; set; }

    public decimal InvAmountBc { get; set; }

    public string UserId { get; set; } = null!;

    public int InvoiceLine { get; set; }
}
