using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class XlsLogPurchaseOrder
{
    public string SupplierId { get; set; } = null!;

    public short YearNo { get; set; }

    public int SerialNo { get; set; }

    public DateTime? GeneratedOn { get; set; }

    public string? CompletePath { get; set; }

    public string? FilenameOnDisk { get; set; }

    public int? WeekNo { get; set; }
}
