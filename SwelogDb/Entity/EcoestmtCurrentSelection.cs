using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class EcoestmtCurrentSelection
{
    public int Spid { get; set; }

    public string? ItemNumberFrom { get; set; }

    public string? ItemNumberTo { get; set; }

    public string? ProductGroupFrom { get; set; }

    public string? ProductGroupTo { get; set; }

    public string? ListYn { get; set; }

    public string? EstimateType { get; set; }

    public int? LotNumber { get; set; }
}
