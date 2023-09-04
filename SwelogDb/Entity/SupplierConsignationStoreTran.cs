using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class SupplierConsignationStoreTran
{
    public int SerialNumber { get; set; }

    public int? HeaderSerialNumber { get; set; }

    public string? EventId { get; set; }

    public DateTime? EventDate { get; set; }

    public decimal? EventQuantity { get; set; }

    public decimal? QuantityBeforeEvent { get; set; }

    public decimal? QuantityAfterEvent { get; set; }

    public string? NewGoodsentryNoUponMove { get; set; }
}
