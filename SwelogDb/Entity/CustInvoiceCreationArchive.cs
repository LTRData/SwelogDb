using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CustInvoiceCreationArchive
{
    public int SerialNumber { get; set; }

    public string? Comments { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? SelectFlag { get; set; }

    public string? CustomerId { get; set; }

    public string? ItemNo { get; set; }

    public decimal? Quantity { get; set; }
}
