using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class VwActualResourceTimeSumupToReport
{
    public string ItemNumber { get; set; } = null!;

    public int LotNumber { get; set; }

    public short OperationNumber { get; set; }

    public string ResourceNumber { get; set; } = null!;

    public DateTime ReportDatetime { get; set; }

    public decimal? SerialNumber { get; set; }

    public decimal? ResourceSetupTime { get; set; }

    public decimal? ResourceTime { get; set; }

    public decimal? QuantityProduced { get; set; }

    public int? NoOfSetup { get; set; }

    public string? ReportCompleteIndicator { get; set; }
}
