using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class CrmProject
{
    public int SerialNumber { get; set; }

    public int? CrmMasterSerialNumber { get; set; }

    public string? ShortDescription { get; set; }

    public string? LongDescription { get; set; }

    public string? ExpectedTimeframe { get; set; }

    public decimal? ExpectedValue { get; set; }

    public decimal? Percent1 { get; set; }

    public decimal? Percent2 { get; set; }

    public short? StatusSerialNumber { get; set; }
}
