using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ResultReportManufactured
{
    public short SerialNo { get; set; }

    public string? OrderNumber { get; set; }

    public string? ItemNumber { get; set; }

    public int? LotNumber { get; set; }

    public decimal? OrderQuantity { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? ReadyDate { get; set; }

    public string? Code { get; set; }

    public DateTime? NewReadyDate { get; set; }

    public string? Status { get; set; }

    public string? TransferFlag { get; set; }

    public DateTime? TransferDate { get; set; }
}
